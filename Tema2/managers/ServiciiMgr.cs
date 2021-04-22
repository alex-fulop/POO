using System;
using System.Collections.Generic;
using System.Xml;

namespace Tema2
{
    public class ServiciiMgr : ProduseMgrAbstract
    {
        public override ProdusAbstract CitireProdus()
        {
            Console.WriteLine("----------- Introdu un serviciu -----------");
            Console.Write("Codul intern: ");
            var codIntern = Console.ReadLine();
            Console.Write("Numele: ");
            var nume = Console.ReadLine();
            Console.Write("Id: ");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pret: ");
            var pret = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Categorie ");
            var categorie = Console.ReadLine();
            return new Serviciu(id, nume, codIntern, pret, categorie);
        }

        public void CitireServicii(int nrServicii)
        {
            while (nrServicii != 0)
            {
                var serviciu = (Serviciu) CitireProdus();
                if (serviciu.CompareWith(Elemente)) Elemente.Add(serviciu);
                nrServicii--;
            }
        }

        public void CitireServicii()
        {
            var listaNoduri = GetListaNoduri();
            foreach (XmlNode nod in listaNoduri)
            {
                var serviciu = GetServiciu(nod);
                if (serviciu.CompareWith(Elemente)) Elemente.Add(serviciu);
            }
        }

        private Serviciu GetServiciu(XmlNode nod)
        {
            var nume = nod["Nume"].InnerText;
            var codIntern = nod["CodIntern"].InnerText;
            var pret = int.Parse(nod["Pret"].InnerText);
            var categorie = nod["Categorie"].InnerText;
            var id = Elemente.Count + 1;
            var serviciu = new Serviciu(id, nume, codIntern, pret, categorie);
            return serviciu;
        }

        private static XmlNodeList GetListaNoduri()
        {
            var doc = new XmlDocument();
            doc.Load("resources/produse.xml");
            var listaNoduri = doc.SelectNodes("/produse/Serviciu"); //Maybe check for null
            return listaNoduri;
        }

        public override void AfisareProduse(List<ProdusAbstract> servicii)
        {
            Console.WriteLine("Serviciile sunt:");
            servicii.ForEach(Console.WriteLine);
        }
    }
}