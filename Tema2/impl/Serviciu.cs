using System.Collections.Generic;
using System.Linq;

namespace Tema2
{
    public class Serviciu : ProdusAbstract
    {
        public Serviciu(int id, string nume, string codIntern) : base(id, nume, codIntern)
        {
        }

        public override bool CompareWith(List<ProdusAbstract> elemente)
        {
            var servicii = elemente.Cast<Serviciu>();
            foreach (Serviciu serviciu in servicii)
            {
                if (Equals(serviciu)) return false;
            }

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
    }
}