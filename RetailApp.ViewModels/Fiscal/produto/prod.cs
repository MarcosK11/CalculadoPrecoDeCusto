namespace RetailApp.ViewModels.Fiscal
{
    public class prod
    {
        public string cProd { get; set; } = default!;
        public string cEAN { get; set; } = default!;
        public string xProd { get; set; } = default!;
        public string NCM { get; set; } = default!;
        public string CFOP { get; set; } = default!;
        public string uCom { get; set; } = default!;
        public decimal qCom { get; set; }
        public decimal vUnCom { get; set; }
        public decimal vProd { get; set; }
        public string cEANTrib { get; set; } = default!;
        public string uTrib { get; set; } = default!;
        public decimal qTrib { get; set; }
        public decimal vUnTrib { get; set; }
        public decimal vDesc { get; set; }
        public bool indTot { get; set; }
        public int nItemPed { get; set; }
    }
}