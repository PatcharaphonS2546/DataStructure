using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collections
{
    public class LinkHeaderCollection : Collection
    {
        private class LinkNode
        {
            public object e;
            public LinkNode next;
            public LinkNode(object e, LinkNode next)
            {
                this.e = e;
                this.next = next;

            }
        }
        private LinkNode first = new LinkNode(null, null);
        private int SIZE;
        public void add(object e)
        {
            first.next = new LinkNode(e, first.next);
            SIZE++;
        }

        public bool contains(object e)
        {
            LinkNode node = first.next;
            while (node != null)
            {
                if (node.e.Equals(e)) return true;
                node = node.next;
            }
            return false;
        }

        public bool isEmpty()
        {
            return SIZE == 0;
        }

        public void remove(object e)
        {
            LinkNode node = first;
            while (node.next != null)
            {
                if (node.next.e.Equals(e))
                {
                    node.next = node.next.next;
                    SIZE--; return;
                }
                node = node.next;
            }
        }

        public int size()
        {
            return SIZE;
        }
    }
}
