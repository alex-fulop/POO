using System;
using System.Collections;
using System.Collections.Generic;

namespace Tema2
{
    public abstract class ProduseMgrAbstract
    {
        ArrayList elemente = new ArrayList();

        public abstract ProdusAbstract CitireProdus();
        public abstract void AfisareProduse(List<ProdusAbstract> elemente);

        public void Write2Console()
        {
            Console.WriteLine("Produsele si serviciile sunt:");
            elemente.DistinctBy(x => new {x.Id, x.Nume, x.CodIntern}).ForEach(Console.WriteLine);
        }
    }
}