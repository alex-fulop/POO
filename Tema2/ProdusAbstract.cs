using System.Collections.Generic;

namespace Tema2
{
    public abstract class ProdusAbstract
    {
        protected string codIntern;
        protected string id;
        protected string nume;

        protected ProdusAbstract(string codIntern, string id, string nume)
        {
            this.codIntern = codIntern;
            this.id = id;
            this.nume = nume;
        }

        public string CodIntern
        {
            get => codIntern;
            set => codIntern = value;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Nume
        {
            get => nume;
            set => nume = value;
        }
        
        public override string ToString()
        {
            return "Serviciu: " + Nume + "[" + CodIntern + "] " + " Id: " + Id;
        }

        public abstract bool CompareWith(List<ProdusAbstract> elemente);
    }
}