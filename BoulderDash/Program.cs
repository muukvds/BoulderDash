﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.controller;

namespace BoulderDash
{
    class Program
    {
        static void Main(string[] args)
        {
            GameController boulderDash = new GameController();
            boulderDash.Start();
        }
    }
}
