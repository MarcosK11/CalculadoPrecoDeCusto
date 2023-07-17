namespace RetailApp.ViewModels.Fiscal
{
    public class ICMS20 : ICMSBase
    {
        public string modBC { get; set; } = default!;
        public string pRedBC { get; set; } = default!;
        public decimal vBC { get; set; } = default!;
        public string pICMS { get; set; } = default!;
        public decimal vICMS { get; set; } = default!;
    }
}