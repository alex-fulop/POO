namespace Tema2
{
    public class Serviciu
    {
        private string codIntern;
        private string id;
        private string nume;

        public Serviciu(string codIntern, string id, string nume)
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
            return "Serviciu: " + Nume + "[" + CodIntern + "] " + Id;
        }
    }
}