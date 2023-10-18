using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program
    {
        private static bool CheckSnakeIntersect()
        {
            for (int i = 1; i < snake.Count; i++)
            {
                if (snake[0] == snake[i])
                    return true;// вернуть true, если координаты нулевой ячейки змейки совпадают с одной из других ее ячеек
            }
            return false;
        }
    }
}
