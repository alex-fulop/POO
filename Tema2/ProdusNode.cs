using System.Xml.Serialization;

namespace Tema2
{
    public class ProdusNode
    {
        [XmlElement(typeof(Produs), ElementName = "Produs")]
        [XmlElement(typeof(Serviciu), ElementName = "Serviciu")]
        [XmlElement(typeof(Pachet), ElementName = "Pachet")]
        public ProdusAbstract Items { get; set; }
    }
}