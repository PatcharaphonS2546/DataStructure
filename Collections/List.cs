﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal interface List : Collection
    {
        void add(int index, object e);
        void remove(int index);
        object get(int index);
        void set(int index, object e);
        int index(object e);
    }
}
