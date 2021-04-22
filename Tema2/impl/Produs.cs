using System;
using System.Linq;
using Tema2.collections;

namespace Tema2
{
    public class Produs : ProdusAbstract, IPackageable
    {
        public Produs(int id, string nume, string codIntern, string producator, decimal pret, string categorie) : base(
            id, nume, codIntern, pret, categorie)
        {
            this.Producator = producator;
        }

        public string Producator { get; set; }

        public bool canAddToPackage(Pachet pachet)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString() + " producator: " + Producator;
        }

        public override string Descriere()
        {
            throw new NotImplementedException();
        }

        public override bool CompareWith(ColectieTipizata elemente)
        {
            var produse = elemente.Cast<Produs>();
            foreach (var produs in produse)
                if (Equals(produs))
                    return false;

            return true;
        }

        public override bool Equals(object obj)
        {
            var produs = obj as Produs;
            if (produs == null) return false;

            if (id == produs.id &&
                nume == produs.nume &&
                codIntern == produs.codIntern &&
                Producator == produs.Producator
            ) return true;
            return false;
        }
    }
}