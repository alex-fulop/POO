using System.Collections.Generic;
using System.Xml.Serialization;

namespace Tema2
{
    public class ProdusRoot
    {
        [XmlElement(ElementName = "Produs")] public List<Produs> produse { get; set; }

        [XmlElement(ElementName = "Serviciu")] public List<Serviciu> servicii { get; set; }

        [XmlElement(ElementName = "Pachet")] public List<Pachet> pachete { get; set; }
    }
}