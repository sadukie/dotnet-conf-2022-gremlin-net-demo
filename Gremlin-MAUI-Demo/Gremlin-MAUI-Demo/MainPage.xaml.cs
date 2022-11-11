using Gremlin.Net.Extensions;
using GremlinDataLayer;
using System.Security.AccessControl;

namespace Gremlin_MAUI_Demo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        Title = "Gremlin.Net MAUI Demo";
        // SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private static Dictionary<string, GremlinQuery[]> queryMap = new Dictionary<string, GremlinQuery[]>{
            { "Load NonTalks", DataLoadQueries.NonTalks },
            { "Load Talks", DataLoadQueries.Talks },
            { "Load Edges", DataLoadQueries.Edges },
            { "Load Talks with Topics", DataLoadQueries.TalksWithTopics },
            { "Get Vertex Count", new GremlinQuery[]{DataQueries.GetVertexCount} },
            { "Get Edge Count", new GremlinQuery[]{DataQueries.GetEdgeCount} },
            { "Get Vertex Labels", new GremlinQuery[]{DataQueries.GetVertexLabels } },
            { "Get Edge Labels", new GremlinQuery[]{DataQueries.GetEdgeLabels} },
            { "Get You!", new GremlinQuery[] { DataQueries.GetYou } },
            { "Get Your Edges", new GremlinQuery[] { DataQueries.GetYourEdges} },
            { "Get Data Talks", new GremlinQuery[] { DataQueries.GetDataTalks } },
            { "Get Data Talks Names", new GremlinQuery[] { DataQueries.GetDataTalkNames } },
            { "Get You to Data Talks", new GremlinQuery[] { DataQueries.GetYouToDataTalks} },
            { "Get You to Data Talks (Path)", new GremlinQuery[] { DataQueries.GetYouToDataTalksPath} },
            { "Get All Edges for Data", new GremlinQuery[] {DataQueries.GetDataAllEdges} },
            { "Get 2 Talks", new GremlinQuery[] {DataQueries.Get2Talks} },
            { "Get Talk Counts By Duration", new GremlinQuery[]{ DataQueries.GetCountsOfTalksByDuration } },
            { "Clear Data", new GremlinQuery[] {DataLoadQueries.ClearGraph } }
        };

    private void ShowParameterizedQueries(object sender, EventArgs e)
    {
        string selectedQuery = ((Button)sender).Text;
        txtSelectedQuery.Text = selectedQuery;
        txtQuery.Text = GremlinQueryHelper.QueriesToString(queryMap[selectedQuery]);
        ToggleUIOnButtonChange();
    }

    private void btnExecuteQuery_Clicked(object sender, EventArgs e)
    {
        txtResponse.Text = GremlinQueryExecutor.ExecuteParameterizedQueries(queryMap[txtSelectedQuery.Text]);
    }

    private void ToggleUIOnButtonChange()
    {
        btnExecuteQuery.Style = txtQuery.Text.IndexOf("drop") != -1 ? (Style)Resources["DangerButton"] : (Style)Resources["DarkButton"];
        txtResponse.Text = "";
    }

    private void btnToggleGraph_Clicked(object sender, EventArgs e)
    {
        imgGraph.IsVisible = !imgGraph.IsVisible;
    }
}

