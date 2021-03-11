using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq;

namespace Tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu numarul de produse: ");
            int nrProduse = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdu numarul de servicii: ");
            int nrServicii = int.Parse(Console.ReadLine());

            List<Serviciu> servicii = new List<Serviciu>();
            List<Produs> produse = new List<Produs>();
            
            while (nrServicii != 0)
            {
                Serviciu serviciu = CitireServiciu(); 
                servicii.Add(serviciu);
                nrServicii--;
            }

            while (nrProduse != 0)
            {
                Produs produs = CitireProdus();
                produse.Add(produs);
                nrProduse--;
            }
            
            Console.WriteLine();
            AfisareProduse(produse.DistinctBy(x => new { x.Id, x.Nume, x.Producator, x.CodIntern }).ToList());
            AfisareServicii(servicii.DistinctBy(x => new { x.Id, x.Nume, x.CodIntern }).ToList());
        }
        
        private static void AfisareProduse(List<Produs> produse)
        {
            Console.WriteLine("Produsele sunt:");
            produse.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
        
        private static void AfisareServicii(List<Serviciu> servicii)
        {
            Console.WriteLine("Serviciile sunt:");
            servicii.ForEach(Console.WriteLine);
        }

        private static Serviciu CitireServiciu()
        {
            Console.WriteLine("Introdu un serviciu");
            Console.Write("Codul intern:");
            String codIntern = Console.ReadLine();
            Console.Write("Numele:");
            String nume = Console.ReadLine();
            Console.Write("Id: ");
            String id = Console.ReadLine();
            return new Serviciu(codIntern, id, nume);
        }
        
        private static Produs CitireProdus()
        {
            Console.WriteLine("Introdu un produs");
            Console.Write("Codul intern:");
            String codIntern = Console.ReadLine();
            Console.Write("Numele:");
            String nume = Console.ReadLine();
            Console.Write("Id: ");
            String id = Console.ReadLine();
            Console.Write("Producator: ");
            String producator = Console.ReadLine();
            return new Produs(codIntern, id, nume, producator);
        }
    }
}