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

        public void ArrangedAdd(T Content)
        {
            ListElement newElement = new ListElement();
            newElement.Content = Content;

            ListElement element = head;
            ListElement helperElement = null;

            while (element != null && element.Content.CompareTo(Content) < 0)
            {
                helperElement = element;
                element = element.Next;
            }

            if (helperElement == null)
            {
                newElement.Next = head;
                head = newElement;
            }
            else
            {
                newElement.Next = element;
                helperElement.Next = newElement;
            }
        }

        public bool ProductSearch(T SearchElement)
        {
            ListElement p = head;
            while (p != null)
            {
                if (p.Content.Equals(SearchElement))
                {
                    return true;
                }
                p = p.Next;
            }
            return false;
        }


    }
}
