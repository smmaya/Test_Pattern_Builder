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
        [Display(Name = "Float/Decimal/Double")]
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

}

