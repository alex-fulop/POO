using System;
using System.Collections.Generic;
using MoreLinq.Extensions;

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
            String id = Console.ReadLine();
            Console.Write("Producator:  ");
            String producator = Console.ReadLine();
            return new Produs(codIntern, id, nume, producator);
        }

        public void CitireProduse(int nrProduse)
        {
            while (nrProduse != 0)
            {
                Produs produs = (Produs) CitireProdus();
                if(produs.CompareWith(elemente)) elemente.Add(produs);
                nrProduse--;
            }
        }
        
        public override void AfisareProduse(List<ProdusAbstract> produse)
        {
            Console.WriteLine("Produsele sunt:");
            produse.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}