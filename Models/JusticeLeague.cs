using System.Xml.Serialization;

namespace TesteBackendUol.Models
{
    [XmlRoot("liga_da_justica")]
    public class JusticeLeague
    {
        [XmlArray("codinomes")]
        [XmlArrayItem("codinome")]
        public List<string> Codinomes { get; set; }
    }
}
