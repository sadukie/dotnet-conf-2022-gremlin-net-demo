using Gremlin.Net.Extensions;

namespace GremlinDataLayer
{
    public class GremlinQueryHelper
    {
        public static string QueryToString(GremlinQuery query)
        {
            string output = "";
            var parameterString = "";
            foreach (var parameter in query.Arguments)
            {
                parameterString += $"{parameter.Key}: {parameter.Value.ToString()}\n";
            }
            output += $"Query: {query.ToString()}\n\nParameters:\n{parameterString}\n\n=====\n";
            return output;
        }

        public static string QueriesToString(GremlinQuery[] queries)
        {
            string output = "";
            foreach (var query in queries)
            {
                output += QueryToString(query);
            }
            return output;
        }

    }
}
