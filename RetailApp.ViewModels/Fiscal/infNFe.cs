
using System.Xml.Serialization;

namespace RetailApp.ViewModels.Fiscal
{
    public class infNFe
    {

        public emit emit { get; set; } = default!;
        public dest dest { get; set; } = default!;
        public ide ide { get; set; } = default!;

        [XmlElement("det")]
        public List<det> det { get; set; } = default!;


        [XmlAttribute("Id")]
        public string Id { get; set; } = default!;

        public total total { get; set; } = default!;
    }
}
