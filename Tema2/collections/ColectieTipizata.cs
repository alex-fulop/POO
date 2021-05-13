using System.Collections;

namespace Tema2.collections
{
    public class ColectieTipizata : CollectionBase
    {
        public void Add(ProdusAbstract produs)
        {
            InnerList.Add(produs);
        }

        public ProdusAbstract FindFirst()
        {
            return (ProdusAbstract) InnerList[0];
        }

        public void Sort()
        {
            InnerList.Sort();
        }
    }
}