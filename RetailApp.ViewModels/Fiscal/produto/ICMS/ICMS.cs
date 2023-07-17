using System.Xml.Serialization;

namespace RetailApp.ViewModels.Fiscal
{
    [XmlRoot("ICMS")]
    public class ICMS
    {
        [XmlElement("ICMS00", typeof(ICMS00))]
        [XmlElement("ICMS10", typeof(ICMS10))]
        [XmlElement("ICMS20", typeof(ICMS20))]
        [XmlElement("ICMS30", typeof(ICMS30))]
        [XmlElement("ICMS40", typeof(ICMS40))]
        //[XmlElement("ICMS50", typeof(ICMS40))]
        [XmlElement("ICMS51", typeof(ICMS51))]
        [XmlElement("ICMS60", typeof(ICMS60))]
        [XmlElement("ICMS70", typeof(ICMS70))]
        [XmlElement("ICMS90", typeof(ICMS90))]
        public ICMSBase ICMSBase { get; set; } = default!;
    }
}