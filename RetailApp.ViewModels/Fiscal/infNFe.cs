
using System.Xml.Serialization;

namespace RetailApp.ViewModels.Fiscal
{
    public class infNFe
    {

        public emit emit { get; set; } = default!;
        public dest dest { get; set; } = default!;
        public ide ide { get; set; } = default!;



        public List<det> det { get; set; }


        [XmlAttribute("Id")]
        public string Id { get; set; } = default!;

    }
}
