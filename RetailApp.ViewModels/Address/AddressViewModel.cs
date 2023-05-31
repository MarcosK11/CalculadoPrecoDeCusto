using RetailApp.ViewModels.Adress;


namespace RetailApp.ViewModels.Address
{
    public class AddressViewModel
    {
        public int IdAddress { get; set; }
        public string StreetName { get; set; } = default!;
        public string StreetNumber { get; set; } = default!;
        public string StreetAditionalInformation { get; set; } = default!;
        public string neighborhood { get; set; } = default!;
        public string ZipCode { get; set; } = default!; 
        public CityViewModel CityViewModel { get; set; } = default!;

    }
}
