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
            String codIntern = Console.ReadLine();
            Console.Write("Numele: ");
            String nume = Console.ReadLine();
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pret: ");
            decimal pret = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Categorie ");
            String categorie = Console.ReadLine();
            return new Serviciu(id, nume, codIntern, pret, categorie);
        }

        public void CitireServicii(int nrServicii)
        {
            while (nrServicii != 0)
            {
                Serviciu serviciu = (Serviciu) CitireProdus();
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
            string nume = nod["Nume"].InnerText;
            string codIntern = nod["CodIntern"].InnerText;
            string producator = nod["Producator"].InnerText;
            int pret = int.Parse(nod["Pret"].InnerText);
            string categorie = nod["Categorie"].InnerText;
            int id = Elemente.Count + 1;
            Serviciu serviciu = new Serviciu(id, nume, codIntern, pret, categorie);
            return serviciu;
        }

        private static XmlNodeList GetListaNoduri()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Produse.xml");
            XmlNodeList listaNoduri = doc.SelectNodes("/produse/Serviciu"); //Maybe check for null
            return listaNoduri;
        }

        public override void AfisareProduse(List<ProdusAbstract> servicii)
        {
            Console.WriteLine("Serviciile sunt:");
            servicii.ForEach(Console.WriteLine);
        }
    }
}