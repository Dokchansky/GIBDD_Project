﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace GIBDD
{
    internal class Singletone
    {
        public static Context DB { get; } = new Context();
    }
}
