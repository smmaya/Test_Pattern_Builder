namespace TestPatternBuilder.Data
{
    public class TestPlan
    {

        public string? Jira { get; set; }
        public string? Description { get; set; }
        public string? Methodology { get; set; }
        public string? Environment { get; set; }
        public string? Browser { get; set; }
        public Boolean? Compliance { get; set; }

        public string? Datasource { get; set; }
        public Boolean? JoinsRequired { get; set; }
        public string? Joins { get; set; }
        public Boolean? CustomFields { get; set; }
        public string? C_Fields { get; set; }
        public Boolean? CustomDimensions { get; set; }
        public string? C_Dimensions { get; set; }
        public Boolean? CustomMeasures { get; set; }
        public string? C_Measures { get; set; }
        public string? Types { get; set; }
        public string? States { get; set; }

    }

}

