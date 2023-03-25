using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Structures
{
    public class BinaryTree<T,N,K> where K: IComparable
    {
        TreeElement root;
        class TreeElement //Adott termék, cikkszám alapján rendezve
        {
            public T Contant;
            public K Key;
            public N ByName; //termék neve
            public TreeElement bal;
            public TreeElement jobb;
        }

        public void Add(T Contant, K Key, N Name)
        {
            _Add(ref root, Contant, Key, Name);
        }
        private void _Add(ref TreeElement p, T Contant, K Key, N Name)
        {
            if (p == null)
            {
                p = new TreeElement();
                p.Contant = Contant;
                p.ByName = Name;
                p.Key = Key;
            }
            else
            {
                if (p.Key.CompareTo(Key) < 0)
                {
                    _Add(ref p.bal, Contant, Key, Name);
                }
                else if (p.Key.CompareTo(Key) > 0)
                {
                    _Add(ref p.jobb, Contant, Key, Name);
                }
                else
                { 
                    _Add(ref p.bal, Contant, Key, Name);
                }
            }
        }

    }
}
