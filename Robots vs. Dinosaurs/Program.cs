﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield sim = new Battlefield();
            sim.Battle();             // .(dot) Notation to call an object
        }
    }
}
