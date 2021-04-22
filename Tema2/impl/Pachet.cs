using System;
using System.Collections.Generic;
using Tema2.collections;

namespace Tema2
{
    public class Pachet : ProdusAbstract, IPackageable
    {
        private readonly List<IPackageable> elem_pachet = new();

        public Pachet(int id, string nume, string codIntern, decimal pret, string categorie) : base(id, nume, codIntern,
            pret, categorie)
        {
        }

        public bool canAddToPackage(Pachet pachet)
        {
            return false;
        }

        public override bool CompareWith(ColectieTipizata elemente)
        {
            throw new NotImplementedException();
        }

        public void addElement(IPackageable prod)
        {
            if (prod.canAddToPackage(this)) elem_pachet.Add(prod);
        }

        public override string Descriere()
        {
            var desc = "";
            foreach (var packageable in elem_pachet)
            {
                var prod = (ProdusAbstract) packageable;
                desc += prod.Descriere() + "\n";
            }

            return "Pachetul contine" + desc;
        }
    }
}