using System;
using System.Collections.Generic;

namespace Tema2
{
    public class ServiciiMgr : ProduseMgrAbstract
    {
        public override ProdusAbstract CitireProdus()
        {
            Console.WriteLine("----------- Introdu un serviciu -----------");
            Console.Write("Codul intern:");
            String codIntern = Console.ReadLine();
            Console.Write("Numele:");
            String nume = Console.ReadLine();
            Console.Write("Id: ");
            String id = Console.ReadLine();
            return new Serviciu(codIntern, id, nume);
        }

        public void CitireServicii(int nrServicii)
        {
            while (nrServicii != 0)
            {
                Serviciu serviciu = (Serviciu) CitireProdus();
                if(serviciu.CompareWith(elemente)) elemente.Add(serviciu);
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