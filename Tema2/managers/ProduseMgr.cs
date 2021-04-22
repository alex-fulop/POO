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
            var codIntern = Console.ReadLine();
            Console.Write("Numele: ");
            var nume = Console.ReadLine();
            Console.Write("Id: ");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Producator:  ");
            var producator = Console.ReadLine();
            Console.Write("Codul intern: ");
            var pret = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ctegorie: ");
            var categorie = Console.ReadLine();
            return new Produs(id, nume, codIntern, producator, pret, categorie);
        }

        public void CitireProduse(int nrProduse)
        {
            while (nrProduse != 0)
            {
                var produs = (Produs) CitireProdus();
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

        private static XmlNodeList GetListaNoduri()
        {
            var doc = new XmlDocument();
            doc.Load("resources/produse.xml");
            var listaNoduri = doc.SelectNodes("/produse/Produs");
            return listaNoduri;
        }

        private Produs GetProdus(XmlNode nod)
        {
            var nume = nod["Nume"].InnerText;
            var codIntern = nod["CodIntern"].InnerText;
            var producator = nod["Producator"].InnerText;
            var pret = int.Parse(nod["Pret"].InnerText);
            var categorie = nod["Categorie"].InnerText;
            var id = Elemente.Count + 1;
            var produs = new Produs(id, nume, codIntern, producator, pret, categorie);
            return produs;
        }

        public override void AfisareProduse(List<ProdusAbstract> produse)
        {
            Console.WriteLine("Produsele sunt:");
            produse.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}