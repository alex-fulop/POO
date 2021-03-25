using System;
using System.Collections.Generic;

namespace Tema2
{
    public abstract class ProduseMgrAbstract
    {
        public static List<ProdusAbstract> elemente = new List<ProdusAbstract>();

        public abstract ProdusAbstract CitireProdus();
        public abstract void AfisareProduse(List<ProdusAbstract> elemente);

        public void Write2Console()
        {
            Console.WriteLine("Produsele si serviciile sunt:");
        }
    }
}