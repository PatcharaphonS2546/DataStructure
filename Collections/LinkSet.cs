using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class LinkSet : LinkHeaderCollection,Set
    {//เป็นlinkset ไม่ต้องจองmemory เลยไม่ต้องมี public ArraySet(int cap) : base(cap) { }
        public new void add(object e)
        {
            if (!base.contains(e))
                base.add(e);
        }
    }
}
