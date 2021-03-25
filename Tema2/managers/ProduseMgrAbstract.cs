using System;
using System.Collections.Generic;
using MoreLinq.Extensions;

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
            elemente.DistinctBy(x => new {x.Id, x.Nume, x.CodIntern}).ForEach(Console.WriteLine);
        }
    }
}