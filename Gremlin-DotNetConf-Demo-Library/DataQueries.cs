using Gremlin.Net.Extensions;
using Gremlin.Net.Process.Traversal;

namespace GremlinDataLayer
{
    public class DataQueries
    {

        private static GraphTraversalSource g => AnonymousTraversalSource.Traversal();

        public static GremlinQuery GetDotNetConf = g.V().Has("id", "dotnetconf").ToGremlinQuery();
        public static GremlinQuery GetYou = g.V().Has("id", "you").ToGremlinQuery();
        public static GremlinQuery GetVertexCount = g.V().Count().ToGremlinQuery();
        public static GremlinQuery GetEdgeCount = g.E().Count().ToGremlinQuery();
        public static GremlinQuery GetVertexLabels = g.V().Label().Dedup().ToGremlinQuery();
        public static GremlinQuery GetEdgeLabels = g.E().Label().Dedup().ToGremlinQuery();
        public static GremlinQuery GetTopics = g.V().HasLabel("Topic").ToGremlinQuery();
        public static GremlinQuery GetTopicCount = g.V().HasLabel("Topic").Count().ToGremlinQuery();
        public static GremlinQuery Get2Talks = g.V().HasLabel("Talk").Limit<string>(2).ToGremlinQuery();
        public static GremlinQuery GetVerticesWithTimePropertyCount = g.V().Has("Time").Count().ToGremlinQuery();
        public static GremlinQuery GetVerticesWithoutTimePropertyCount = g.V().HasNot("Time").Count().ToGremlinQuery();
        public static GremlinQuery GetTalksByTopic = g.V().HasLabel("Topic").As("topics").OutE().InV().As("talks").Select<string>("topics", "talks").ToGremlinQuery();
        public static GremlinQuery GetCountsOfTalksByDuration = g.V().HasLabel("Talk").GroupCount<string>().By("Length").ToGremlinQuery();
        public static GremlinQuery GetPath = g.V().HasLabel("Topic").As("topics").OutE().InV().As("talks").Select<string>("topics", "talks").Path().ToGremlinQuery();
        public static GremlinQuery[] CrudDemo = new GremlinQuery[] {
        g.AddV("Talk").Property("id","talk999").Property("name","Test Talk").Property("pk","pk").ToGremlinQuery(),
        g.V().Has("id","talk999").ToGremlinQuery(),
        g.V().Has("id","talk999").Drop().ToGremlinQuery(),
    };
        public static GremlinQuery DataTopicAndTalks = g.V().HasLabel("Topic").Has("name", "Data").As("dataTopics").OutE("contains").InV().As("talks").ToGremlinQuery();

        public static GremlinQuery[] FromYouToDataTalks = new GremlinQuery[]{
            g.V().HasLabel("Person").OutE().InV().OutE().InV().ToGremlinQuery()
        };
    }
}