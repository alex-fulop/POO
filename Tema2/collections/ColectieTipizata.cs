using System;
using System.Collections;
using Tema2.utils;

namespace Tema2.collections
{
    public class ColectieTipizata : CollectionBase
    {
        public void Add(ProdusAbstract produs)
        {
            InnerList.Add(produs);
        }

        public void Sort()
        {
            Console.WriteLine("Se sorteaza produsele si serviciile dupa id...");
            InnerList.Sort(new IdComparer());
        }

        public ArrayList GetInnerList()
        {
            return InnerList;
        }
    }
}