using System;
using System.Collections.Generic;
using Tema2.collections;

namespace Tema2
{
    public abstract class ProduseMgrAbstract
    {
        public ColectieTipizata Elemente { get; } = new();

        public abstract ProdusAbstract CitireProdus();
        public abstract void AfisareProduse(List<ProdusAbstract> elemente);

        public void Write2Console()
        {
            // elemente.Sort();
            Console.WriteLine("Produsele si serviciile sunt:");
            foreach (var element in Elemente) Console.WriteLine(element);
        }
    }
}