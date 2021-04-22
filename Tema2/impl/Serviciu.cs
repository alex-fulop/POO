using System;
using System.Linq;
using Tema2.collections;

namespace Tema2
{
    public class Serviciu : ProdusAbstract, IPackageable
    {
        public Serviciu(int id, string nume, string codIntern, decimal pret, string categorie) : base(id, nume,
            codIntern, pret, categorie)
        {
        }

        public bool canAddToPackage(Pachet pachet)
        {
            throw new NotImplementedException();
        }

        public override string Descriere()
        {
            throw new NotImplementedException();
        }

        public override bool CompareWith(ColectieTipizata elemente)
        {
            var servicii = elemente.Cast<Serviciu>();
            foreach (var serviciu in servicii)
                if (Equals(serviciu))
                    return false;

            return true;
        }

        public override bool Equals(object obj)
        {
            var serviciu = obj as Serviciu;
            if (serviciu == null) return false;

            if (id == serviciu.id &&
                nume == serviciu.nume &&
                codIntern == serviciu.codIntern
            ) return true;
            return false;
        }
    }
}