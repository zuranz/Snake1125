﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static bool SnakeEatToxicApple()
        {
            return ToxicApple[0] == snake[0][0] && ToxicApple[1] == snake[0][1];
            
        }
    }
}
