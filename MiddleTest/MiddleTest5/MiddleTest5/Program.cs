﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midT
{
    public delegate void MyEventHandler(int k);
    class Button
    {
        int a;
        public event MyEventHandler Push;

    }

}
