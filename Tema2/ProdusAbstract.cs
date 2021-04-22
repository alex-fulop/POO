using Tema2.collections;

namespace Tema2
{
    public abstract class ProdusAbstract
    {
        protected string categorie;
        protected string codIntern;
        protected int id;
        protected string nume;
        protected decimal pret;

        protected ProdusAbstract(int id, string nume, string codIntern, decimal pret, string categorie)
        {
            this.id = id;
            this.nume = nume;
            this.pret = pret;
            this.codIntern = codIntern;
            this.categorie = categorie;
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

        public decimal Pret
        {
            get => pret;
            set => pret = value;
        }

        public string Categorie
        {
            get => categorie;
            set => categorie = value;
        }

        public override string ToString()
        {
            return "Serviciu: " + Nume + "[" + CodIntern + "] " + " Id: " + Id;
        }

        public abstract string Descriere();

        public abstract bool CompareWith(ColectieTipizata elemente);
    }
}