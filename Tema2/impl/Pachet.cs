using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Tema2
{
    [Serializable]
    [XmlRoot("Pachet")]
    public class Pachet : ProdusAbstract, IPackageable
    {
        private readonly List<IPackageable> elem_pachet = new();

        public Pachet(int id, string nume, string codIntern, decimal pret, string categorie) : base(id, nume, codIntern,
            pret, categorie)
        {
        }

        public Pachet()
        {
        }

        public bool canAddToPackage(Pachet pachet)
        {
            return false;
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

        public override bool CompareWith(List<ProdusAbstract> elemente)
        {
            var pachete = elemente.Cast<Pachet>();
            foreach (var pachet in pachete)
                if (Equals(pachet))
                    return false;

            return true;
        }

        public override string ToString()
        {
            return "Pachet: " + base.ToString();
        }
    }
}