using System.Xml.Serialization;

namespace RetailApp.ViewModels.Fiscal
{
    public class det
    {
        [XmlAttribute("nItem")]
        public int nItem { get; set; }
        public prod prod { get; set; } 
        public imposto imposto { get; set; } 

    }
}