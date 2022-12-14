using Gremlin.Net.Extensions;
using Gremlin.Net.Process.Traversal;

namespace GremlinDataLayer
{
    public class DataLoadQueries
    {
        private static GraphTraversalSource g => AnonymousTraversalSource.Traversal();

        // We don"t need to do a g.E().drop() since edges are stored with their source vertices
        public static GremlinQuery ClearGraph = g.V().Drop().ToGremlinQuery();

        public static GremlinQuery[] NonTalks = new GremlinQuery[]{
        g.AddV("Person").Property("id","you").Property("name","You").Property("pk","pk").ToGremlinQuery(),
        g.AddV("Event").Property("id","dotnetconf").Property("name",".NET Conf").Property("pk","pk").ToGremlinQuery(),
        g.AddV("Topic").Property("id","keynote").Property("name","Keynote").Property("pk","pk").ToGremlinQuery(),
        g.AddV("Topic").Property("id","web").Property("name","Web").Property("pk","pk").ToGremlinQuery(),
        g.AddV("Topic").Property("id","data").Property("name","Data").Property("pk","pk").ToGremlinQuery(),
        g.AddV("Topic").Property("id","client").Property("name","Client").Property("pk","pk").ToGremlinQuery(),
        g.AddV("Topic").Property("id","dotnetstories").Property("name",".NET Developer Stories").Property("pk","pk").ToGremlinQuery(),
        g.AddV("Topic").Property("id","general").Property("name","General").Property("pk","pk").ToGremlinQuery(),
        g.AddV("Topic").Property("id","deeperdotnet").Property("name","Deeper .NET").Property("pk","pk").ToGremlinQuery(),
        g.AddV("Topic").Property("id","blazor").Property("name","Blazor").Property("pk","pk").ToGremlinQuery(),
        g.AddV("Topic").Property("id","github").Property("name","GitHub").Property("pk","pk").ToGremlinQuery(),
        g.AddV("Topic").Property("id","powerplatform").Property("name","Power Platform / Teams").Property("pk","pk").ToGremlinQuery(),
        g.AddV("Topic").Property("id","windows").Property("name","Windows").Property("pk","pk").ToGremlinQuery(),
        g.AddV("Topic").Property("id","modernization").Property("name","Modernization").Property("pk","pk").ToGremlinQuery(),
        g.AddV("Topic").Property("id","linux").Property("name","Linux").Property("pk","pk").ToGremlinQuery(),
        g.AddV("Topic").Property("id","mlai").Property("name","ML/AI").Property("pk","pk").ToGremlinQuery(),
        g.AddV("Topic").Property("id","serverless").Property("name","Serverless").Property("pk","pk").ToGremlinQuery(),
        g.AddV("Topic").Property("id","accessibility").Property("name","Accessibility").Property("pk","pk").ToGremlinQuery(),
        g.AddV("Topic").Property("id","games").Property("name","Games").Property("pk","pk").ToGremlinQuery(),
        g.AddV("Topic").Property("id","cloud").Property("name","Cloud").Property("pk","pk").ToGremlinQuery()
    };

        public static GremlinQuery[] Talks = new GremlinQuery[]{
        g.AddV("Talk").Property("id","talk1").Property("name",".NET Conf 2022 Keynote: Welcome to .NET 7").Property("pk","pk").Property("Time","2022-11-08 08:00:00").Property("Length",60.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk2").Property("name","State of ASP.NET Core").Property("pk","pk").Property("Time","2022-11-08 09:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk3").Property("name","What???s new for Blazor in .NET 7").Property("pk","pk").Property("Time","2022-11-08 09:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk4").Property("name","Making the Most of Minimal APIs in .NET 7").Property("pk","pk").Property("Time","2022-11-08 10:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk5").Property("name","Building modern high-performance services with ASP.NET Core and .NET 7").Property("pk","pk").Property("Time","2022-11-08 10:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk6").Property("name","State of Azure + .NET").Property("pk","pk").Property("Time","2022-11-08 11:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk7").Property("name","The Whirlwind Tour of Building .NET Apps in Azure").Property("pk","pk").Property("Time","2022-11-08 11:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk8").Property("name","Building Serverless Applications with .NET 7 and Azure functions").Property("pk","pk").Property("Time","2022-11-08 12:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk9").Property("name","Azure Container Apps with .NET").Property("pk","pk").Property("Time","2022-11-08 12:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk10").Property("name","State of .NET MAUI").Property("pk","pk").Property("Time","2022-11-08 13:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk11").Property("name","What???s new in .NET MAUI and Desktop Apps").Property("pk","pk").Property("Time","2022-11-08 13:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk12").Property("name","Performance Improvements in .NET MAUI (.NET 7 edition)").Property("pk","pk").Property("Time","2022-11-08 14:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk13").Property("name","Create native desktop & mobile apps using web skills in Blazor Hybrid").Property("pk","pk").Property("Time","2022-11-08 14:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk14").Property("name",".NET at Stack Overflow").Property("pk","pk").Property("Time","2022-11-08 15:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk15").Property("name","Using .NET to build the .NET website").Property("pk","pk").Property("Time","2022-11-08 15:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk16").Property("name","Microsoft Teams Backend Services - Powered by .NET").Property("pk","pk").Property("Time","2022-11-08 16:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk17").Property("name","How Halo, Dynamics 365, and Mesh scale to millions with Orleans and you can too!").Property("pk","pk").Property("Time","2022-11-08 16:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk18").Property("name",".NET Conf CodeParty 2022").Property("pk","pk").Property("Time","2022-11-08 17:00:00").Property("Length",90.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk19").Property("name","What???s New in C# 11").Property("pk","pk").Property("Time","2022-11-09 08:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk20").Property("name","Performance Improvements in .NET 7").Property("pk","pk").Property("Time","2022-11-09 08:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk21").Property("name","Let???s design a new C# language feature!").Property("pk","pk").Property("Time","2022-11-09 09:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk22").Property("name",".NET Architects Panel").Property("pk","pk").Property("Time","2022-11-09 09:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk23").Property("name",".NET ?????????s WebAssembly in .NET 7").Property("pk","pk").Property("Time","2022-11-09 10:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk24").Property("name","Building a Blazor component").Property("pk","pk").Property("Time","2022-11-09 10:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk25").Property("name","Testing Blazor Applications with Playwright").Property("pk","pk").Property("Time","2022-11-09 11:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk26").Property("name","GitHub Universe + .NET Conf Epic Crossover").Property("pk","pk").Property("Time","2022-11-09 11:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk27").Property("name","Microsoft Dev Box for .NET Developers").Property("pk","pk").Property("Time","2022-11-09 12:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk28").Property("name","Boost your .NET productivity with Low Code Tools").Property("pk","pk").Property("Time","2022-11-09 12:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk29").Property("name","Rapidly create a front-end for your web APIs with Microsoft Power Apps").Property("pk","pk").Property("Time","2022-11-09 13:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk30").Property("name","Building Microsoft Teams Bots with .NET & the Teams Toolkit").Property("pk","pk").Property("Time","2022-11-09 13:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk31").Property("name","Building Windows apps with WinUI 3 with .NET").Property("pk","pk").Property("Time","2022-11-09 14:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk32").Property("name","Accelerate your WinUI 3 app with the Windows Community Toolkit").Property("pk","pk").Property("Time","2022-11-09 14:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk33").Property("name","Modernize your WPF and Windows Forms application with Blazor").Property("pk","pk").Property("Time","2022-11-09 15:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk34").Property("name","Upgrading from .NET Framework to .NET 7").Property("pk","pk").Property("Time","2022-11-09 15:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk35").Property("name","Using CoreWCF to unblock modernization of WCF apps").Property("pk","pk").Property("Time","2022-11-09 16:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk36").Property("name","High-performance services with gRPC: What???s new in .NET 7").Property("pk","pk").Property("Time","2022-11-09 16:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk37").Property("name","Upgrading Xamarin apps to .NET MAUI").Property("pk","pk").Property("Time","2022-11-09 17:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk38").Property("name","CSS Techniques for Blazor Developers").Property("pk","pk").Property("Time","2022-11-09 17:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk39").Property("name","Accepting Payments with Stripe Checkout").Property("pk","pk").Property("Time","2022-11-09 18:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk40").Property("name","The Power of Polyglot Notebooks").Property("pk","pk").Property("Time","2022-11-09 18:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk41").Property("name","Slaying Zombie ???No Repro??? Crashes with Infer#").Property("pk","pk").Property("Time","2022-11-09 19:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk42").Property("name",".NET Interop Improvements in .NET 7").Property("pk","pk").Property("Time","2022-11-09 19:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk43").Property("name","Visual Studio Code for C# Developers").Property("pk","pk").Property("Time","2022-11-09 20:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk44").Property("name","Migrate Your Legacy ASP.NET Projects to ASP.NET Core Incrementally with YARP").Property("pk","pk").Property("Time","2022-11-09 20:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk45").Property("name","MVVM is easier than ever before with Source Generators, .NET 7, and the MVVM Toolkit").Property("pk","pk").Property("Time","2022-11-09 21:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk46").Property("name","Deep Learning in .NET").Property("pk","pk").Property("Time","2022-11-09 21:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk47").Property("name","T4 goodness with Entity Framework Core 7").Property("pk","pk").Property("Time","2022-11-09 22:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk48").Property("name","Build More Predictable Event-Driven System with CloudEvents, .NET and Azure").Property("pk","pk").Property("Time","2022-11-09 22:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk49").Property("name","From RESTful HTTP API to gRPC").Property("pk","pk").Property("Time","2022-11-09 23:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk50").Property("name","Human-readable Razor views with ASP.NET 7 Tag Helpers").Property("pk","pk").Property("Time","2022-11-09 23:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk51").Property("name","Tips and tricks on platform-code implementation in .NET MAUI").Property("pk","pk").Property("Time","2022-11-10 00:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk52").Property("name","Aloha .NET MAUI Community Toolkit").Property("pk","pk").Property("Time","2022-11-10 00:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk53").Property("name","Pushing C# to new places with NativeAOT").Property("pk","pk").Property("Time","2022-11-10 01:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk54").Property("name","Authorization in a Distributed / Microservice System").Property("pk","pk").Property("Time","2022-11-10 01:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk55").Property("name","Down the Oregon Trail with Functional C#").Property("pk","pk").Property("Time","2022-11-10 02:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk56").Property("name",".NET 7, Docker, K8S and Azure DevOps").Property("pk","pk").Property("Time","2022-11-10 02:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk57").Property("name","Leverage the power of the GPU, DX12 and D2D1 with ease using ComputeSharp").Property("pk","pk").Property("Time","2022-11-10 03:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk58").Property("name","Using Durable Azure Functions in .NET 7").Property("pk","pk").Property("Time","2022-11-10 03:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk59").Property("name","Performance tricks I learned from contributing to the Azure .NET SDK").Property("pk","pk").Property("Time","2022-11-10 04:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk60").Property("name","Building a .NET SDK library with Open API and NSwag").Property("pk","pk").Property("Time","2022-11-10 04:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk61").Property("name","WatchDog: What???s New in Open-source Logging").Property("pk","pk").Property("Time","2022-11-10 05:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk62").Property("name","Dynamically.Adding functionality to ASP.NET Core").Property("pk","pk").Property("Time","2022-11-10 05:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk63").Property("name","ASP.NET Basics for Experts").Property("pk","pk").Property("Time","2022-11-10 06:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk64").Property("name",".NET Configuration In Depth").Property("pk","pk").Property("Time","2022-11-10 06:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk65").Property("name","Networking in .NET 7.0").Property("pk","pk").Property("Time","2022-11-10 07:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk66").Property("name","Creating Business Applications Using Azure Maps").Property("pk","pk").Property("Time","2022-11-10 07:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk67").Property("name","Building .NET apps on WSL").Property("pk","pk").Property("Time","2022-11-10 08:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk68").Property("name","Using .NET with Chiseled Ubuntu Containers").Property("pk","pk").Property("Time","2022-11-10 08:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk69").Property("name",".NET GUI Applications for Embedded Linux Using Containers").Property("pk","pk").Property("Time","2022-11-10 09:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk70").Property("name","Leveling up data: Upgrade from EF6 to EF7 and blast off!").Property("pk","pk").Property("Time","2022-11-10 09:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk71").Property("name","Navigating Graphs in Azure Cosmos DB using Gremlin.Net").Property("pk","pk").Property("Time","2022-11-10 10:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk72").Property("name","Event Sourcing with Marten and Postgresql").Property("pk","pk").Property("Time","2022-11-10 10:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk73").Property("name","Announcing ML.NET 2.0").Property("pk","pk").Property("Time","2022-11-10 11:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk74").Property("name","Machine learning models with ONNX and .NET").Property("pk","pk").Property("Time","2022-11-10 11:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk75").Property("name","Lessons learnt using DevContainers and the Azure Developer Cli to code apps anywhere, anytime.").Property("pk","pk").Property("Time","2022-11-10 12:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk76").Property("name","Clean Architecture with ASP.NET Core 7").Property("pk","pk").Property("Time","2022-11-10 12:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk77").Property("name",".NET 7 on App Service").Property("pk","pk").Property("Time","2022-11-10 13:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk78").Property("name","Azure Static Web Apps with Blazor and .NET").Property("pk","pk").Property("Time","2022-11-10 13:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk79").Property("name","Building Accessible Apps with .NET MAUI").Property("pk","pk").Property("Time","2022-11-10 14:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk80").Property("name","Performance benefits of .NET 7 for Web Applications").Property("pk","pk").Property("Time","2022-11-10 14:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk81").Property("name","Making Technology More Accessible with .NET and AI").Property("pk","pk").Property("Time","2022-11-10 15:00:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk82").Property("name","Build games with C# and Visual Studio").Property("pk","pk").Property("Time","2022-11-10 15:30:00").Property("Length",30.0).ToGremlinQuery(),
        g.AddV("Talk").Property("id","talk83").Property("name","The future of .NET in real time 3D applications using Unity").Property("pk","pk").Property("Time","2022-11-10 16:00:00").Property("Length",60.0).ToGremlinQuery()
    };

        public static GremlinQuery[] Edges = new GremlinQuery[]{
        g.V().Has("id","you").AddE("interested in").To(g.V().HasLabel("Topic").Has("id","data")).ToGremlinQuery(),
        g.V().Has("id","dotnetconf").AddE("covers").To(g.V().HasLabel("Topic").Has("id","keynote")).ToGremlinQuery(),
        g.V().Has("id","dotnetconf").AddE("covers").To(g.V().HasLabel("Topic").Has("id","web")).ToGremlinQuery(),
        g.V().Has("id","dotnetconf").AddE("covers").To(g.V().HasLabel("Topic").Has("id","data")).ToGremlinQuery(),
        g.V().Has("id","dotnetconf").AddE("covers").To(g.V().HasLabel("Topic").Has("id","client")).ToGremlinQuery(),
        g.V().Has("id","dotnetconf").AddE("covers").To(g.V().HasLabel("Topic").Has("id","dotnetstories")).ToGremlinQuery(),
        g.V().Has("id","dotnetconf").AddE("covers").To(g.V().HasLabel("Topic").Has("id","general")).ToGremlinQuery(),
        g.V().Has("id","dotnetconf").AddE("covers").To(g.V().HasLabel("Topic").Has("id","deeperdotnet")).ToGremlinQuery(),
        g.V().Has("id","dotnetconf").AddE("covers").To(g.V().HasLabel("Topic").Has("id","blazor")).ToGremlinQuery(),
        g.V().Has("id","dotnetconf").AddE("covers").To(g.V().HasLabel("Topic").Has("id","github")).ToGremlinQuery(),
        g.V().Has("id","dotnetconf").AddE("covers").To(g.V().HasLabel("Topic").Has("id","powerplatform")).ToGremlinQuery(),
        g.V().Has("id","dotnetconf").AddE("covers").To(g.V().HasLabel("Topic").Has("id","windows")).ToGremlinQuery(),
        g.V().Has("id","dotnetconf").AddE("covers").To(g.V().HasLabel("Topic").Has("id","modernization")).ToGremlinQuery(),
        g.V().Has("id","dotnetconf").AddE("covers").To(g.V().HasLabel("Topic").Has("id","linux")).ToGremlinQuery(),
        g.V().Has("id","dotnetconf").AddE("covers").To(g.V().HasLabel("Topic").Has("id","mlai")).ToGremlinQuery(),
        g.V().Has("id","dotnetconf").AddE("covers").To(g.V().HasLabel("Topic").Has("id","serverless")).ToGremlinQuery(),
        g.V().Has("id","dotnetconf").AddE("covers").To(g.V().HasLabel("Topic").Has("id","accessibility")).ToGremlinQuery(),
        g.V().Has("id","dotnetconf").AddE("covers").To(g.V().HasLabel("Topic").Has("id","games")).ToGremlinQuery(),
        g.V().Has("id","dotnetconf").AddE("covers").To(g.V().HasLabel("Topic").Has("id","cloud")).ToGremlinQuery()
    };

        public static GremlinQuery[] TalksWithTopics = new GremlinQuery[] {
        g.V().HasLabel("Topic").Has("id","keynote").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk1")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","web").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk2")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","web").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk3")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","web").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk4")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","web").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk5")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","cloud").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk6")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","cloud").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk7")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","cloud").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk8")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","cloud").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk9")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","client").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk10")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","client").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk11")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","client").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk12")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","client").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk13")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","dotnetstories").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk14")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","dotnetstories").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk15")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","dotnetstories").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk16")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","dotnetstories").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk17")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk18")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","deeperdotnet").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk19")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","deeperdotnet").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk20")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","deeperdotnet").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk21")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","deeperdotnet").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk22")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","blazor").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk23")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","blazor").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk24")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","blazor").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk25")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","github").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk26")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","github").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk27")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","powerplatform").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk28")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","powerplatform").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk29")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","powerplatform").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk30")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","windows").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk31")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","windows").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk32")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","windows").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk33")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","modernization").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk34")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","modernization").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk35")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","modernization").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk36")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk37")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk38")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk39")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk40")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk41")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk42")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk43")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk44")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk45")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk46")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk47")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk48")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk49")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk50")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk51")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk52")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk53")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk54")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk55")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk56")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk57")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk58")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk59")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk60")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk61")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk62")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk63")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk64")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk65")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk66")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","linux").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk67")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","linux").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk68")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","linux").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk69")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","data").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk70")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","data").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk71")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","data").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk72")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","mlai").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk73")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","mlai").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk74")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","mlai").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk75")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk76")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk77")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk78")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk79")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk80")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","general").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk81")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","games").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk82")).ToGremlinQuery(),
        g.V().HasLabel("Topic").Has("id","games").AddE("contains").To(g.V().HasLabel("Talk").Has("id","talk83")).ToGremlinQuery()
    };

    }
}