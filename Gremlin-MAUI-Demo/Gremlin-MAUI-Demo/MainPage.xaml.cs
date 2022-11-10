using GremlinDataLayer;

namespace Gremlin_MAUI_Demo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        Title = "Gremlin.Net MAUI Demo";
        // SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void btnGetVertexCount_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = DataQueries.GetVertexCount;
        txtSelectedQuery.Text = "vertex count";
        ToggleUIOnButtonChange();
    }

    private void btnGetVertexLabels_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = DataQueries.GetVertexLabels;
        txtSelectedQuery.Text = "vertex labels";
        ToggleUIOnButtonChange();
    }

    private void btnGetEdgeCount_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = DataQueries.GetEdgeCount;
        txtSelectedQuery.Text = "edge count";
        ToggleUIOnButtonChange();
    }

    private void btnGetEdgeLabels_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = DataQueries.GetEdgeLabels;
        txtSelectedQuery.Text = "edge labels";
        ToggleUIOnButtonChange();
    }

    private void btnClearData_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = DataLoadQueries.ClearGraph;
        txtSelectedQuery.Text = "clear";
        ToggleUIOnButtonChange();
    }

    private void btnGetDotnetConf_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = GremlinQueryHelper.QueryToString(DataQueries.GetDotNetConf);
        txtSelectedQuery.Text = "get dotnet conf";
        ToggleUIOnButtonChange();
    }

    private void btnLoadNonTalks_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = GremlinQueryHelper.QueriesToString(DataLoadQueries.NonTalks);
        txtSelectedQuery.Text = "load nontalks";
        ToggleUIOnButtonChange();
    }

    private void btnLoadTalks_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = GremlinQueryHelper.QueriesToString(DataLoadQueries.Talks);
        txtSelectedQuery.Text = "load talks";
        ToggleUIOnButtonChange();
    }

    private void btnLoadEdges_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = GremlinQueryHelper.QueriesToString(DataLoadQueries.Edges);
        txtSelectedQuery.Text = "load edges";
        ToggleUIOnButtonChange();
    }

    private void btnLoadTalksWithTopics_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = GremlinQueryHelper.QueriesToString(DataLoadQueries.TalksWithTopics);
        txtSelectedQuery.Text = "load talks with topics";
        ToggleUIOnButtonChange();
    }

    private void btnExecuteQuery_Clicked(object sender, EventArgs e)
    {
        txtResponse.Text = "Executing...";
        string result = "";
        switch (txtSelectedQuery.Text)
        {
            case "clear":
                result = GremlinQueryExecutor.ExecuteParameterizedQuery(DataLoadQueries.ClearGraph);
                break;
            case "load talks":
                result = GremlinQueryExecutor.ExecuteParameterizedQueries(DataLoadQueries.Talks);
                break;
            case "load nontalks":
                result = GremlinQueryExecutor.ExecuteParameterizedQueries(DataLoadQueries.NonTalks);
                break;
            case "load edges":
                result = GremlinQueryExecutor.ExecuteParameterizedQueries(DataLoadQueries.Edges);
                break;
            case "load talks with topics":
                result = GremlinQueryExecutor.ExecuteParameterizedQueries(DataLoadQueries.TalksWithTopics);
                break;
            case "vertex count":
                result = GremlinQueryExecutor.ExecuteParameterizedQuery(DataQueries.GetVertexCount);
                break;
            case "edge count":
                result = GremlinQueryExecutor.ExecuteParameterizedQuery(DataQueries.GetEdgeCount);
                break;
            case "get dotnet conf":
                result = GremlinQueryExecutor.ExecuteParameterizedQuery(DataQueries.GetDotNetConf);
                break;
            case "vertex labels":
                result = GremlinQueryExecutor.ExecuteParameterizedQuery(DataQueries.GetVertexLabels);
                break;
            case "edge labels":
                result = GremlinQueryExecutor.ExecuteParameterizedQuery(DataQueries.GetEdgeLabels);
                break;
            case "get 2 talks":
                result = GremlinQueryExecutor.ExecuteParameterizedQuery(DataQueries.Get2Talks);
                break;
            case "get talks with topics":
                result = GremlinQueryExecutor.ExecuteParameterizedQuery(DataQueries.GetTalksByTopic);
                break;
            case "get talk counts by duration":
                result = GremlinQueryExecutor.ExecuteParameterizedQuery(DataQueries.GetCountsOfTalksByDuration);
                break;
            default:
                break;
        }
        txtResponse.Text = result;
    }

    private void ToggleUIOnButtonChange()
    {
        btnExecuteQuery.Style = txtQuery.Text.IndexOf("drop") != -1 ? (Style)Resources["DangerButton"] : (Style)Resources["DarkButton"];
        txtResponse.Text = "";
    }

    private void btnGet2Talks_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = DataQueries.Get2Talks;
        txtSelectedQuery.Text = "get 2 talks";
        ToggleUIOnButtonChange();
    }

    private void btnTalksWithTopics_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = DataQueries.GetTalksByTopic;
        txtSelectedQuery.Text = "get talks with topics";
        ToggleUIOnButtonChange();
    }

    private void btnGetTalkCountsByDuration_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = DataQueries.GetCountsOfTalksByDuration;
        txtSelectedQuery.Text = "get talk counts by duration";
        ToggleUIOnButtonChange();
    }
}

