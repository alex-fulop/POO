using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Tema2
{
    [Serializable]
    [XmlRoot("Produs")]
    public class Produs : ProdusAbstract, IPackageable
    {
        public Produs(int id, string nume, string codIntern, string producator, decimal pret, string categorie) : base(
            id, nume, codIntern, pret, categorie)
        {
            Producator = producator;
        }

        public Produs()
        {
        }

        public string Producator { get; set; }

        public bool canAddToPackage(Pachet pachet)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Produs: " + base.ToString() + " producator: " + Producator;
        }

        public override string Descriere()
        {
            throw new NotImplementedException();
        }

        public override bool CompareWith(List<ProdusAbstract> elemente)
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