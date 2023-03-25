using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Structures
{
    public class BinaryTree<T,N,K> where K: IComparable
    {
        class TreeElement //Adott termék, cikkszám alapján rendezve
        {
            public T Contant;
            public K Key;
            public N ByName; //termék neve
            public TreeElement bal;
            public TreeElement jobb;
        }
    }
}
