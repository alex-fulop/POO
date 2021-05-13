using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Tema2
{
    public abstract class ProduseMgrAbstract
    {
        private static readonly Type[] PROD_ABSTRACT_TYPES =
        {
            typeof(Serviciu),
            typeof(Produs),
            typeof(Pachet)
        };

        public List<ProdusAbstract> Elemente { get; set; } = new();

        public abstract ProdusAbstract CitireProdus();
        public abstract void AfisareProduse(List<ProdusAbstract> elemente);

        public void Write2Console()
        {
            // elemente.Sort();
            Console.WriteLine("Produsele si serviciile sunt:");
            foreach (var element in Elemente) Console.WriteLine(element);
        }

        public void save2XML(string fileName)
        {
            var xs = new XmlSerializer(typeof(List<ProdusAbstract>), PROD_ABSTRACT_TYPES);
            var sw = new StreamWriter(fileName + ".xml");

            xs.Serialize(sw, Elemente);
            sw.Close();
        }

        public List<ProdusAbstract> loadFromXML(string fileName)
        {
            var serializer = new XmlSerializer(typeof(ProdusRoot));
            var stream = new FileStream(fileName + ".xml", FileMode.Open);

            XmlReader reader = new XmlTextReader(stream);
            var abstractProducts = (ProdusRoot) serializer.Deserialize(reader);
            stream.Close();

            var allProdusAbstracts = GetAllProdusAbstracts(abstractProducts);

            return allProdusAbstracts;
        }

        private static List<ProdusAbstract> GetAllProdusAbstracts(ProdusRoot abstractProducts)
        {
            var allProdusAbstracts = new List<ProdusAbstract>();
            if (abstractProducts != null)
            {
                abstractProducts.produse.ForEach(p => allProdusAbstracts.Add(p));
                abstractProducts.servicii.ForEach(p => allProdusAbstracts.Add(p));
                abstractProducts.pachete.ForEach(p => allProdusAbstracts.Add(p));
            }

            return allProdusAbstracts;
        }
    }
}