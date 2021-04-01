using Tema2.collections;

namespace Tema2
{
    public abstract class ProdusAbstract
    {
        protected string codIntern;
        protected int id;
        protected string nume;

        protected ProdusAbstract(int id, string nume, string codIntern)
        {
            this.id = id;
            this.nume = nume;
            this.codIntern = codIntern;
        }

        public string CodIntern
        {
            get => codIntern;
            set => codIntern = value;
        }

        public int Id
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

        public abstract bool CompareWith(ColectieTipizata elemente);
    }
}