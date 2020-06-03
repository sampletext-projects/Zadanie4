using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    public class Module
    {
        public double Area6(double d)
        {
            double r = d / 2; //радиус
            double a1 = r * r * Math.Sqrt(3) / 4; //площадь треугольника
            double a = a1 * 6; //треугольников 6
            return a;
        }

        public static string ConvertBase82(int val)
        {
            string res = "";
            while (val != 0)
            {
                int digit = val % 10;

                switch (digit)
                {
                    case 0: res = "000" + res ; break;
                    case 1: res = "001" + res ; break;
                    case 2: res = "010" + res ; break;
                    case 3: res = "011" + res ; break;
                    case 4: res = "100" + res ; break;
                    case 5: res = "101" + res ; break;
                    case 6: res = "110" + res ; break;
                    case 7: res = "111" + res ; break;
                }

                val /= 10;
            }

            return res;
        }
    }
}