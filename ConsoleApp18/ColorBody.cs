using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static void ColorBody()
        {
            

            for (int i = 2; i < snake.Count; i++)
            {
                graphics.FillEllipse(System.Drawing.Brushes.Blue, snake[i][0], snake[i][1], 10, 10);
            }
        }
        
    }
}
