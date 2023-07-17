using System.Xml.Serialization;

namespace RetailApp.ViewModels.Fiscal
{
    public abstract class ICMSBase
    {
        // Propriedades comuns do ICMS
        public string orig { get; set; } = default!;
        public string CST { get; set; } = default!;
        public decimal vFCPST { get; set; } = default!;

    }
}