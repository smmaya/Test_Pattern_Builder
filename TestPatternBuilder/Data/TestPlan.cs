namespace TestPatternBuilder.Data;

public class TestPlan
{
    public string? Jira { get; set; }
    public string? Description { get; set; }
    public string? Methodology { get; set; }
    public string? Environment { get; set; }
    public string? Browser { get; set; }
    public bool? Compliance { get; set; }

    public string? Datasource { get; set; }
    public bool? JoinsRequired { get; set; }
    public string? Joins { get; set; }
    public bool? CustomFields { get; set; }
    public string? C_Fields { get; set; }
    public bool? CustomDimensions { get; set; }
    public string? C_Dimensions { get; set; }
    public bool? CustomMeasures { get; set; }
    public string? C_Measures { get; set; }
    public string? Types { get; set; }
    public string? States { get; set; }
}