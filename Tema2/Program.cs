using System;

namespace Tema2
{
    internal class Program
    {
        private static readonly ProduseMgr ProduseMgr = new();
        private static readonly ServiciiMgr ServiciiMgr = new();

        private static void Main(string[] args)
        {
            // ReadUserInput();

            // Produs prod1 = new Produs(1, "Produs", "CodProd", "Producator");
            // Serviciu serv1 = new Serviciu(2, "Serviciu", "CodServ");

            // ProduseMgr.elemente.Add(prod1);
            // ProduseMgr.elemente.Add(serv1);

            ProduseMgr.CitireProduse();
            ServiciiMgr.CitireServicii();

            // Deserialize
            var produseAbstracte = ServiciiMgr.loadFromXML("resources/produse");
            foreach (var produsAbstract in produseAbstracte) Console.WriteLine(produsAbstract);

            // Serialize 
            // if (ServiciiMgr.Elemente[0] is Serviciu) 
            //     ServiciiMgr.save2XML("result");

            Console.WriteLine();
            // ProduseMgr.Write2Console();
        }

        private static void ReadUserInput()
        {
            Console.WriteLine("Introdu numarul de produse: ");
            var nrProduse = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Introdu numarul de servicii: ");
            var nrServicii = int.Parse(Console.ReadLine() ?? string.Empty);

            ProduseMgr.CitireProduse(nrProduse);
            ServiciiMgr.CitireServicii(nrServicii);
        }
    }
}