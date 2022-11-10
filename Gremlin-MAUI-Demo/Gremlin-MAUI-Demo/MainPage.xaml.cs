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

    private void btnGetYou_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = GremlinQueryHelper.QueryToString(DataQueries.GetYou);
        txtSelectedQuery.Text = "get you";
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
            case "get you":
                result = GremlinQueryExecutor.ExecuteParameterizedQuery(DataQueries.GetYou);
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
            case "get talk counts by duration":
                result = GremlinQueryExecutor.ExecuteParameterizedQuery(DataQueries.GetCountsOfTalksByDuration);
                break;
            case "get your edges":
                result = GremlinQueryExecutor.ExecuteParameterizedQuery(DataQueries.GetYourEdges);
                break;
            case "get data talks":
                result = GremlinQueryExecutor.ExecuteParameterizedQuery(DataQueries.GetDataTalks);
                break;
            case "get data talk names":
                result = GremlinQueryExecutor.ExecuteParameterizedQuery(DataQueries.GetDataTalkNames);
                break;
            case "get you to data talks":
                result = GremlinQueryExecutor.ExecuteParameterizedQuery(DataQueries.GetYouToDataTalks);
                break;
            case "get you to data talks path":
                result = GremlinQueryExecutor.ExecuteParameterizedQuery(DataQueries.GetYouToDataTalksPath);
                break;
            case "get all data edges":
                result = GremlinQueryExecutor.ExecuteParameterizedQuery(DataQueries.GetDataAllEdges);
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

    private void btnGetTalkCountsByDuration_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = DataQueries.GetCountsOfTalksByDuration;
        txtSelectedQuery.Text = "get talk counts by duration";
        ToggleUIOnButtonChange();
    }

    private void btnGetYourEdges_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = GremlinQueryHelper.QueryToString(DataQueries.GetYourEdges);
        txtSelectedQuery.Text = "get your edges";
        ToggleUIOnButtonChange();
    }

    private void btnGetDataTalks_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = GremlinQueryHelper.QueryToString(DataQueries.GetDataTalks);
        txtSelectedQuery.Text = "get data talks";
        ToggleUIOnButtonChange();
    }

    private void btnGetDataTalksNames_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = GremlinQueryHelper.QueryToString(DataQueries.GetDataTalkNames);
        txtSelectedQuery.Text = "get data talk names";
        ToggleUIOnButtonChange();
    }

    private void btnGetYouToDataTalks_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = GremlinQueryHelper.QueryToString(DataQueries.GetYouToDataTalks);
        txtSelectedQuery.Text = "get you to data talks";
        ToggleUIOnButtonChange();
    }

    private void btnGetYouToDataTalksPath_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = GremlinQueryHelper.QueryToString(DataQueries.GetYouToDataTalksPath);
        txtSelectedQuery.Text = "get you to data talks path";
        ToggleUIOnButtonChange();
    }

    private void btnGetDataAllEdges_Clicked(object sender, EventArgs e)
    {
        txtQuery.Text = GremlinQueryHelper.QueryToString(DataQueries.GetDataAllEdges);
        txtSelectedQuery.Text = "get all data edges";
        ToggleUIOnButtonChange();
    }
}

