using System.Collections;

namespace Tema2.collections
{
    public class ColectieTipizata : CollectionBase
    {
        public void Add(ProdusAbstract produs)
        {
            InnerList.Add(produs);
        }

        public void Sort()
        {
            InnerList.Sort();
        }
    }
}