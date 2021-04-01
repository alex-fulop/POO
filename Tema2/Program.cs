using System;

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

            // Produs prod1 = new Produs(1, "Produs", "CodProd", "Producator");
            // Serviciu serv1 = new Serviciu(2, "Serviciu", "CodServ");

            // ProduseMgr.elemente.Add(prod1);
            // ProduseMgr.elemente.Add(serv1);

            ProduseMgr.CitireProduse(nrProduse);
            ServiciiMgr.CitireServicii(nrServicii);

            Console.WriteLine();
            ProduseMgr.Write2Console();
        }
    }
}