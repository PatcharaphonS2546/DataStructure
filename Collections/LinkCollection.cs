using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    
    public class LinkCollection : Collection
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
        private LinkNode first;
        private int SIZE;

        public void add(object e)
        {
            first = new LinkNode(e, first);
            SIZE++;
        }

        public void remove(object e)
        {
            if (first == null) return;
            if (first.e.Equals(e))
            {
                first = first.next;
                SIZE--; return;
            }
            LinkNode node  = first;
            while (node != null)
            {
                if(node.next != null && node.next.e.Equals(e))//ข้างหน้าไม่เท่ากับnull && ในnodeมีค่าเท่ากับe
                {
                    node.next = node.next.next;
                    SIZE--;return;
                }
                node = node.next;
            }
        }

        public bool contains(object e)
        {
            LinkNode node = first;
            while (node != null)
            {
                if (node.e.Equals(e)) return true;//nodeมีค่าเดียวกับobjectไหม?
                node = node.next;
            }
            return false;
        }

        public int size()
        {
            return SIZE;
        }

        public bool isEmpty()
        {
            return SIZE == 0;
        }
    }
}
