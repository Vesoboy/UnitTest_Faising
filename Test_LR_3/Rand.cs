using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LR_1;

namespace Test_LR_3
{
    internal class Rand
    {
        public int len;
        public string st_rand;
        public Rand(int len)
        {
            this.len = len;
        }
        public int StrRand()
        {
            Random random = new Random();//пытаемся рандомить от чисел в диапозоне 97-122
            for (int i = 0; i < len; i++)
            {
                int numb1 = random.Next(65, 90);//ENGL
                int numb2 = random.Next(97, 122);//engl
                int numb3 = random.Next(0, 64);
                int numb4 = random.Next(91, 96);
                int numb5 = random.Next(123, 256);

                char cb1 = Convert.ToChar(numb1);//вытаскиваем символы
                char cb2 = Convert.ToChar(numb2);//вытаскиваем символы
                char cb3 = Convert.ToChar(numb3);//вытаскиваем символы
                char cb4 = Convert.ToChar(numb4);//вытаскиваем символы
                char cb5 = Convert.ToChar(numb5);//вытаскиваем символы

                st_rand += cb1;
                st_rand += cb2;
                st_rand += cb3;
                st_rand += cb4;
                st_rand += cb5;
            }
            var obj = new Count(st_rand);

            return obj.CountText();
        }
    }
}
