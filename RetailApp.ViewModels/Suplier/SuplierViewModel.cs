using RetailApp.ViewModels.Address;
using RetailApp.ViewModels.Phone;

namespace RetailApp.ViewModels.Suplier
{
    public class SuplierViewModel
    {
        public int IdSuplier { get; set; }
        public string CNPJ { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Comercialname { get; set; } = default!;
        public string IE { get; set; } = default!;
        public string IEST { get; set; } = default!;
        public int CRT { get; set; }
        public List<AddressViewModel> addresViewModel { get; set; } = default!;
        public List<PhoneViewModel> PhoneViewModel { get; set; } = default!;
    }
}
