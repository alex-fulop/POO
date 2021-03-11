namespace Tema2
{
    public class Produs
    {
        private string codIntern;
        private string id;
        private string nume;
        private string producator;

        public Produs(string codIntern, string id, string nume, string producator)
        {
            this.codIntern = codIntern;
            this.id = id;
            this.nume = nume;
            this.producator = producator;
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

        public string Producator
        {
            get => producator;
            set => producator = value;
        }

        public override string ToString()
        {
           return "Produs: " + Nume + "[" + CodIntern + "] " + " producator: " + Producator + " id: " + id;
        }
    }
}