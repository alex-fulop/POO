using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq;

namespace Tema2
{
    class Program
    {
        private static readonly ProduseMgr ProduseMgr = new ProduseMgr();
        private static readonly ServiciiMgr ServiciiMgr = new ServiciiMgr();
        
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu numarul de produse: ");
            int nrProduse = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Introdu numarul de servicii: ");
            int nrServicii = int.Parse(Console.ReadLine() ?? string.Empty);

            ProduseMgr.CitireProduse(nrProduse);
            ServiciiMgr.CitireServicii(nrServicii);

            Console.WriteLine();
            ProduseMgr.Write2Console();
        }
    }
}