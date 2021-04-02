using System.Collections;

namespace Tema2.utils
{
    public class IdComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            ProdusAbstract elem1 = (ProdusAbstract) x;
            ProdusAbstract elem2 = (ProdusAbstract) y;
            return elem1.Id.CompareTo(elem2.Id);
        }
    }
}