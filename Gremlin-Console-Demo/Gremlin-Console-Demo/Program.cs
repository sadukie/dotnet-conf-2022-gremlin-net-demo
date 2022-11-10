using Gremlin.Net.Extensions;
using GremlinDataLayer;

namespace GremlinConsoleDemo
{
    class Program
    {
        private static bool showResourceCosts = true;

        static void Main(string[] args)
        {
            bool runApp = true;
            while (runApp)
            {
                int selection = 1;
                while (selection > 0 && selection <= menuOptions.Count)
                {
                    PrintMenu();
                    Console.WriteLine("Choose an option. Select 0 to quit.");
                    try
                    {
                        selection = Convert.ToInt16(Console.ReadLine());
                        if (selection == 0)
                        {
                            runApp = false;
                            break;
                        }
                        else
                        {
                            ProcessMenu(selection, true);
                        }
                    } catch (Exception ex) {
                        Console.WriteLine(ex.Message.ToString());
                        runApp = false;
                        break;
                    }
                }
            }
        }

        private static Dictionary<string, GremlinQuery[]> menuOptions = new Dictionary<string, GremlinQuery[]>{
            { "Load nontalks", DataLoadQueries.NonTalks },
            { "Load talks", DataLoadQueries.Talks },
            { "Load edges (relationships)", DataLoadQueries.Edges },
            { "Load talks with topics edges", DataLoadQueries.TalksWithTopics },            
            { "Get the vertex count", new GremlinQuery[]{DataQueries.GetVertexCount} },
            { "Get the edge count", new GremlinQuery[]{DataQueries.GetEdgeCount} },
            { "Get vertex labels", new GremlinQuery[]{DataQueries.GetVertexLabels } },
            { "Get edge labels", new GremlinQuery[]{DataQueries.GetEdgeLabels} },
            { "Get You!", new GremlinQuery[] { DataQueries.GetYou } },
            { "Get Data talks", new GremlinQuery[] { DataQueries.GetDataTalks } },
            { "Get Data talks (only names)", new GremlinQuery[] { DataQueries.GetDataTalkNames } },
            { "Get You to Data Talks", new GremlinQuery[] { DataQueries.GetYouToDataTalks} },
            { "Get You to Data Talks (path)", new GremlinQuery[] { DataQueries.GetYouToDataTalksPath} },
            { "Get 2 talks", new GremlinQuery[] {DataQueries.Get2Talks} },
            { "Get talks with their topics", new GremlinQuery[] { DataQueries.GetTalksByTopic } },
            { "Get count of talks by duration (minutes)", new GremlinQuery[]{ DataQueries.GetCountsOfTalksByDuration } }, 
            { "Clear the graph", new GremlinQuery[] {DataLoadQueries.ClearGraph } }
        };

        private static void PrintMenu()
        {
            Console.WriteLine(".NET Conf Gremlin.Net Demo");
            Console.WriteLine("=========");
            for (int menuItemCounter = 0; menuItemCounter < menuOptions.Keys.Count(); menuItemCounter++)
            {
                Console.WriteLine($"{menuItemCounter + 1}. { menuOptions.Keys.ElementAt(menuItemCounter)}");
            }
        }

        private static void ProcessMenu(int selection, bool confirm = false)
        {
            Console.WriteLine("=======");
            if (selection > menuOptions.Count || selection < 0)
            {
                Console.WriteLine("Not a valid menu option");
            }
            else
            {
                var selectedQueries = menuOptions.ElementAt(selection-1).Value;
                Console.WriteLine("Selected query:");
                Console.WriteLine(GremlinQueryHelper.QueriesToString(selectedQueries));
                if (confirm)
                {
                    Console.WriteLine("Execute? ([Y]/N): ");
                    string confirmation = Console.ReadLine() ?? "Y";
                    if (confirmation.ToLower() == "n")
                    {
                        return;
                    }
                }
                var results = GremlinQueryExecutor.ExecuteParameterizedQueries(selectedQueries,showResourceCosts);
                WriteOutputWithPause(results,pauseTimeInMilliseconds:0,promptToContinue:true);
            }
        }

        private static void WriteOutputWithPause(string output, int pauseTimeInMilliseconds = 1000, bool promptToContinue = false)
        {
            Console.WriteLine(output);
            Thread.Sleep(pauseTimeInMilliseconds);
            if (promptToContinue)
            {
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.WriteLine("\n\n");
            }
        }

    }
}