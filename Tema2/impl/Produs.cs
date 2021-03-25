using System.Collections.Generic;
using System.Linq;

namespace Tema2
{
    public class Produs : ProdusAbstract
    {
        private string producator;

        public Produs(int id, string nume, string codIntern, string producator) : base(codIntern, id, nume)
        {
            this.producator = producator;
        }

        public string Producator
        {
            get => producator;
            set => producator = value;
        }

        public override string ToString()
        {
            return base.ToString() + " producator: " + Producator;
        }

        public override bool CompareWith(List<ProdusAbstract> elemente)
        {
            var produse = elemente.Cast<Produs>();
            foreach (Produs produs in produse)
            {
                if (Equals(produs)) return false;
            }

            return true;
        }

        public override bool Equals(object obj)
        {
            var produs = obj as Produs;
            if (produs == null) return false;

            if (id == produs.id &&
                nume == produs.nume &&
                codIntern == produs.codIntern &&
                producator == produs.producator
            ) return true;
            return false;
        }
    }
}