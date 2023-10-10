using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VolodinaAA.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string cardname;
            switch (value1)
            {
                case 1: cardname = " пик";break;
                case 2: cardname = " треф";break;
                case 3: cardname = " бубен";break;
                case 4: cardname = " черв";break;
                default: throw new ArgumentException("Такой цифры не существует в колоде карт");

            }
            switch (value2)
            {
                case 6: cardname = "Шестёрка"+cardname;break;
                case 7: cardname = "Семёрка"+cardname;break;
                case 8: cardname = "Восьмёрка"+cardname;break;
                case 9: cardname = "Девятка"+cardname;break;
                case 10: cardname = "Десятка"+cardname;break;
                case 11: cardname = "Валет"+cardname;break;
                case 12: cardname = "Дама"+cardname;break;
                case 13: cardname = "Король"+cardname;break;
                case 14: cardname = "Туз"+cardname;break;
                default: throw new ArgumentException("Такой цифры не существует в колоде карт");
                
                
            }
            return cardname;
        }
    }
}
