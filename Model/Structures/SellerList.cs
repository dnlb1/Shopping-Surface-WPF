using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Structures
{
    public class SellerList<T> where T : IComparable
    {
        class ListElement
        {
            public T Content;
            public ListElement Next;
        }
        ListElement head;

        public void Add(T Content)
        {
            ListElement newElement = new ListElement();
            newElement.Next = head;
            newElement.Content = Content;
            head = newElement;
        }


    }
}
