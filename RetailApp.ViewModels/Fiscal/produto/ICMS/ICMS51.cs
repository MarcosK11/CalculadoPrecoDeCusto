namespace RetailApp.ViewModels.Fiscal
{
    public class ICMS51 : ICMSBase
    {
        public string modBC { get; set; } = default!;
        public string pRedBC { get; set; } = default!;
        public double vBC { get; set; } = default!;
        public string pICMS { get; set; } = default!;
        public double vICMSOp { get; set; } = default!;
        public string pDif { get; set; } = default!;
        public double vICMSDif { get; set; } = default!;
        public double vICMS { get; set; } = default!;
    }

}