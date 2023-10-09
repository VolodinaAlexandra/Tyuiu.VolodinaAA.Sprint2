using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VolodinaAA.Sprint2.Task2.V14.Lib
{
    public class DataService : ISprint2Task2V14
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (((x >= 10) && (x <= 13) && (y >= 2) && (y <= 3)) || ((x >= 10) && (x <= 12) && (y >= 4) && (y <= 5)) || ((x >= 3) && (x <= 5) && (y >= 3) && (y <= 7)) || ((x == 2) && (y >= 4) && (y <= 5))|| (((x == 9) && (y == 5)) || ((x >= 6) && (x <= 8) && (y >= 5) && (y <= 10)) || ((x >= 3) && (x <= 13) && (y == 11)) || ((y >= 9) && (y <= 13) && (x == 13)) || ((x >= 7) && (x <= 10) && (y == 12))))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }   


    }
}
