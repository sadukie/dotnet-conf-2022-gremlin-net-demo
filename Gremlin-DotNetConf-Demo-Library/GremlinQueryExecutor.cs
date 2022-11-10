using Gremlin.Net.Driver;
using Gremlin.Net.Driver.Exceptions;
using Gremlin.Net.Extensions;
using Gremlin.Net.Structure.IO.GraphSON;
using System.Net.WebSockets;
using System.Text.Json;

/// <summary>
/// Sample program that shows how to get started with the Graph (Gremlin) APIs for Azure Cosmos DB using the open-source connector Gremlin.Net
/// </summary>
/// 
namespace GremlinDataLayer
{
    public class GremlinQueryExecutor
    {
        // Azure Cosmos DB Configuration variables
        // Replace the values in these variables to your own.
        // <configureConnectivity>
        private static string Host => Environment.GetEnvironmentVariable("Host") ?? throw new ArgumentException("Missing env var: Host");
        private static string PrimaryKey => Environment.GetEnvironmentVariable("PrimaryKey") ?? throw new ArgumentException("Missing env var: PrimaryKey");
        private static string Database => Environment.GetEnvironmentVariable("DatabaseName") ?? throw new ArgumentException("Missing env var: DatabaseName");
        private static string Container => Environment.GetEnvironmentVariable("ContainerName") ?? throw new ArgumentException("Missing env var: ContainerName");

        private static bool EnableSSL = true;
        private static int Port = 443;
        // Partition key is required if you create graph containers from the Azure portal or the 3.x or higher versions of Gremlin drivers.
        // We have created this in the portal ahead of running this program.
        private static string PartitionKey = "pk";

        public static string ExecuteParameterizedQuery(GremlinQuery query,bool showStatusAttributes = true)
        {
            return ExecuteParameterizedQueries(new GremlinQuery[] { query }, showStatusAttributes);
        }

        public static string ExecuteParameterizedQueries(GremlinQuery[] queries, bool showStatusAttributes = true)
        {
            // <defineClientandServerObjects>
            string containerLink = "/dbs/" + Database + "/colls/" + Container;

            var gremlinServer = new GremlinServer(Host, Port, enableSsl: EnableSSL,
                                                    username: containerLink,
                                                    password: PrimaryKey);

            ConnectionPoolSettings connectionPoolSettings = new ConnectionPoolSettings()
            {
                MaxInProcessPerConnection = 10,
                PoolSize = 30,
                ReconnectionAttempts = 3,
                ReconnectionBaseDelay = TimeSpan.FromMilliseconds(500)
            };

            var webSocketConfiguration =
                new Action<ClientWebSocketOptions>(options =>
                {
                    options.KeepAliveInterval = TimeSpan.FromSeconds(10);
                });


            using (var gremlinClient = new GremlinClient(
                gremlinServer,
                new GraphSON2Reader(),
                new GraphSON2Writer(),
                GremlinClient.GraphSON2MimeType,
                connectionPoolSettings,
                webSocketConfiguration))
            {
                string output = ExecuteParameterizedQueries(gremlinClient, queries, showStatusAttributes);
                return output;
            }
        }

        private static string ExecuteParameterizedQueries(GremlinClient gremlinClient, GremlinQuery[] gremlinQueries, bool ShowStatusAttributes = true)
        {
            string output = "";
            foreach (var query in gremlinQueries)
            {
                // Create async task to execute the Gremlin query.
                //
                var resultSet = SubmitParameterizedRequest(gremlinClient, query).Result;
                if (resultSet.Count > 0)
                {
                    output += ("\nResult:");
                    foreach (var result in resultSet)
                    {
                        // The vertex results are formed as Dictionaries with a nested dictionary for their properties
                        output += $"\n{JsonSerializer.Serialize(result)}";
                    }
                    output += "\n---\n";
                }

                // Print the status attributes for the result set.
                // This includes the following:
                //  x-ms-status-code            : This is the sub-status code which is specific to Cosmos DB.
                //  x-ms-total-request-charge   : The total request units charged for processing a request.
                //  x-ms-total-server-time-ms   : The total time executing processing the request on the server.
                if (ShowStatusAttributes)
                {
                    output += GetStatusAttributes(resultSet.StatusAttributes);
                }
                output += "\n";

            }
            return output;
        }

        private static Task<ResultSet<dynamic>> SubmitParameterizedRequest(GremlinClient gremlinClient, GremlinQuery query)
        {
            try
            {
                var queryParams = new Dictionary<string, object>(query.Arguments);
                return gremlinClient.SubmitAsync<dynamic>(query.ToString(), queryParams);
            }
            catch (ResponseException e)
            {
                Console.WriteLine("\nRequest Error!");

                // Print the Gremlin status code.
                Console.WriteLine($"\nStatusCode: {e.StatusCode}");

                // On error, ResponseException.StatusAttributes will include the common StatusAttributes for successful requests, as well as
                // additional attributes for retry handling and diagnostics.
                // These include:
                //  x-ms-retry-after-ms         : The number of milliseconds to wait to retry the operation after an initial operation was throttled. This will be populated when
                //                              : attribute 'x-ms-status-code' returns 429.
                //  x-ms-activity-id            : Represents a unique identifier for the operation. Commonly used for troubleshooting purposes.
                GetStatusAttributes(e.StatusAttributes);
                Console.WriteLine($"\n[\"x-ms-retry-after-ms\"] : {GetValueAsString(e.StatusAttributes, "x-ms-retry-after-ms")}");
                Console.WriteLine($"\n[\"x-ms-activity-id\"] : {GetValueAsString(e.StatusAttributes, "x-ms-activity-id")}");

                throw;
            }
        }

        private static string GetStatusAttributes(IReadOnlyDictionary<string, object> attributes)
        {
            string statusAttributes = $"StatusAttributes:";
            statusAttributes += $"\n[\"x-ms-status-code\"] : {GetValueAsString(attributes, "x-ms-status-code")}";
            statusAttributes += $"\n[\"x-ms-total-server-time-ms\"] : {GetValueAsString(attributes, "x-ms-total-server-time-ms")}";
            statusAttributes += $"\n[\"x-ms-total-request-charge\"] : {GetValueAsString(attributes, "x-ms-total-request-charge")}";
            return statusAttributes;
        }

        public static string GetValueAsString(IReadOnlyDictionary<string, object> dictionary, string key)
        {
            return JsonSerializer.Serialize(GetValueOrDefault(dictionary, key));
        }

        public static object GetValueOrDefault(IReadOnlyDictionary<string, object> dictionary, string key)
        {
            if (dictionary.ContainsKey(key))
            {
                return dictionary[key];
            }

            return null;
        }
    }
}