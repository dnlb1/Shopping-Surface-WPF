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
            public TreeElement left;
            public TreeElement right;
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
                    _Add(ref p.left, Contant, Key, Name);
                }
                else if (p.Key.CompareTo(Key) > 0)
                {
                    _Add(ref p.right, Contant, Key, Name);
                }
                else
                { 
                    _Add(ref p.left, Contant, Key, Name);
                }
            }
        }

        public T ArticleNumberSearch(K Key)
        {
            return _ArticleNumberSearch(root, Key);
        }

        private T _ArticleNumberSearch(TreeElement p, K Key)
        {
            if (p != null)
            {
                int x = p.Key.CompareTo(Key);
                if (p.Key.CompareTo(Key) < 0)
                {
                    return _ArticleNumberSearch(p.left, Key);
                }
                else if (p.Key.CompareTo(Key) > 0)
                {
                   return _ArticleNumberSearch(p.right, Key);
                }
                else
                {
                    return p.Contant;
                }
            }
            else
            {
                return default(T); 
            }
        }

    }
}
