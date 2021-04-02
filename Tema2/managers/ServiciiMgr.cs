using System;
using System.Collections.Generic;

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

        public override void AfisareProduse(List<ProdusAbstract> servicii)
        {
            Console.WriteLine("Serviciile sunt:");
            servicii.ForEach(Console.WriteLine);
        }
    }
}