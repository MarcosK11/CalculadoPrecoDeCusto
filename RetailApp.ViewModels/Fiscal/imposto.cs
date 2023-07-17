namespace RetailApp.ViewModels.Fiscal
{
    public class imposto
    {
        public double vTotTrib { get; set; } = default!;
        public ICMS ICMS { get; set; } = default!;
        public IPI IPI { get; set; } = default!;
        public PIS PIS { get; set; } = default!;
        public COFINS COFINS { get; set; } = default!;
        public ICMSUFDest ICMSUFDest { get; set; } = default!;
    }
}