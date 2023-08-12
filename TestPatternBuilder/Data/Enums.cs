using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace TestPatternBuilder.Data
{
    public enum Browsers
    {
        Chrome,
        Edge,
        Firefox,
        Opera,
        Safari,
        Vivaldi
    }

    public enum Types
    {
        Int,
        Boolean,
        [Display(Name = "Date")]
        Date,
        [Display(Name = "Date (Timestamp)")]
        Date_Timestamp,
        [Display(Name = "Float/Decimal")]
        Float_Double_Decimal,
        String
    }

    public enum Methods
    {
        Exploration,
        [Display(Name = "Issue Related")]
        Issue_Related,
        Regression,
        Acceptance,
        Sanity
    }

    public enum Environments
    {
        Branch,
        DEV,
        QA,
        RC,
        PROD
    }

    public enum Components
    {
        Auth,
        Backend,
        [Display(Name = "Middle Layer")]
        Middle_Layer,
        Visualisations,
        [Display(Name = "UX/UI")]
        UX_UI,
        Other
    }

    public enum Datasources
    {
        Snowflake,
        [Display(Name = "Google Sheets")]
        GoogleSheets,
        PostgreSQL,
        [Display(Name = "Google BigQuery")]
        GoogleBigQuery,
        Dremio,
        Databricks,
        Redshift
    }
    
    [Flags]
    public enum InternalDependencies
    {
        [Display(Name = "Printing")]
        Printing = 1,
        [Display(Name = "Embedability")]
        Embeds = 2,
        [Display(Name = "View/Preview")]
        View_Preview = 4,
        [Display(Name = "Actions")]
        Actions = 8,
        [Display(Name = "Roles")]
        Roles = 16,
        [Display(Name = "Backward Compatibility")]
        Backward_Compatibility = 32,
        [Display(Name = "Demo Assets")]
        Demo_Assets = 64,
        [Display(Name = "Access Control")]
        Access_Control = 128,
        [Display(Name = "Import/Export")]
        Import_Export = 256,
        [Display(Name = "Theming")]
        Theming = 512,
    }

}

