using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp18 
{
    partial class Program
    {
        private static void Proverka()
        {


            for (int i = 1; i < snake.Count; i++)
            {
                if (apple[0] == snake[i][0] && apple[1] == snake[i][1])
                    GenerateApple();
                if (ToxicApple[0] == snake[i][0] && ToxicApple[1] == snake[i][1])
                    GenerateToxicApple();
            }
        }
    }

}
