using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Tema2
{
    [Serializable]
    public abstract class ProdusAbstract
    {
        [XmlAttribute(AttributeName = "Categorie")]
        protected string categorie;

        [XmlAttribute(AttributeName = "CodIntern")]
        protected string codIntern;

        [XmlAttribute(AttributeName = "Id")] protected int id;
        [XmlAttribute(AttributeName = "Nume")] protected string nume;
        [XmlAttribute(AttributeName = "Pret")] protected decimal pret;

        protected ProdusAbstract()
        {
        }

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
            return Nume + "[" + CodIntern + "] " + " Id: " + Id;
        }

        public abstract string Descriere();

        public abstract bool CompareWith(List<ProdusAbstract> elemente);
    }
}