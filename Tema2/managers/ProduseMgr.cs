using System;
using System.Collections.Generic;
using System.Xml;

namespace Tema2
{
    public class ProduseMgr : ProduseMgrAbstract
    {
        public override ProdusAbstract CitireProdus()
        {
            Console.WriteLine("----------- Introdu un produs -----------");
            Console.Write("Codul intern: ");
            String codIntern = Console.ReadLine();
            Console.Write("Numele: ");
            String nume = Console.ReadLine();
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Producator:  ");
            String producator = Console.ReadLine();
            Console.Write("Codul intern: ");
            decimal pret = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ctegorie: ");
            String categorie = Console.ReadLine();
            return new Produs(id, nume, codIntern, producator, pret, categorie);
        }

        public void CitireProduse(int nrProduse)
        {
            while (nrProduse != 0)
            {
                Produs produs = (Produs) CitireProdus();
                if (produs.CompareWith(Elemente)) Elemente.Add(produs);
                nrProduse--;
            }
        }

        public void CitireProduse()
        {
            var listaNoduri = GetListaNoduri();
            foreach (XmlNode nod in listaNoduri)
            {
                var produs = GetProdus(nod);
                if (produs.CompareWith(Elemente)) Elemente.Add(produs);
            }
        }

        private Produs GetProdus(XmlNode nod)
        {
            string nume = nod["Nume"].InnerText;
            string codIntern = nod["CodIntern"].InnerText;
            string producator = nod["Producator"].InnerText;
            int pret = int.Parse(nod["Pret"].InnerText);
            string categorie = nod["Categorie"].InnerText;
            int id = Elemente.Count + 1;
            Produs produs = new Produs(id, nume, codIntern, producator, pret, categorie);
            return produs;
        }

        private static XmlNodeList GetListaNoduri()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("produse.xml");
            XmlNodeList listaNoduri = doc.SelectNodes("/produse/Produs"); //Maybe check for null
            return listaNoduri;
        }

        public override void AfisareProduse(List<ProdusAbstract> produse)
        {
            Console.WriteLine("Produsele sunt:");
            produse.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}