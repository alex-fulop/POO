using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Tema2
{
    [Serializable]
    [XmlRoot("Serviciu")]
    public class Serviciu : ProdusAbstract, IPackageable
    {
        public Serviciu(int id, string nume, string codIntern, decimal pret, string categorie) : base(id, nume,
            codIntern, pret, categorie)
        {
        }

        public Serviciu()
        {
        }

        public bool canAddToPackage(Pachet pachet)
        {
            throw new NotImplementedException();
        }

        public override string Descriere()
        {
            return "Aceasta entitate este un serviciu";
        }

        public override bool CompareWith(List<ProdusAbstract> elemente)
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

        public override string ToString()
        {
            return "Serviciu: " + base.ToString();
        }

        // public void save2File(string fileName)
        // {
        //     FileStream fs = new FileStream(fileName, FileMode.Create);
        //     BinaryFormatter formatter = new BinaryFormatter();
        //     formatter.Serialize(fs, this.Elemente);
        //     fs.Close();
        // }
    }
}