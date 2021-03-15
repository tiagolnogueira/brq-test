using System.ComponentModel;

namespace BRQ.CreditTest.Domain.Enums
{
    public enum Category
    {
        [Description("DEFAULTED")]
        DEFAULTED,
        [Description("HIGHRISK")]
        HIGHRISK,
        [Description("MEDIUMRISK")]
        MEDIUMRISK,
        [Description("PEP")]
        PEP
    }
}
