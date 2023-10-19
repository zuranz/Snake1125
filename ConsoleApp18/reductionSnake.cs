using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        
            private static void reductionSnake()
            {
            graphics.FillEllipse(System.Drawing.Brushes.Black, snake[snake.Count - 1][0], snake[snake.Count - 1][1], 10, 10);
            snake.RemoveAt(snake.Count - 1);
            
        }
        
    }
}
