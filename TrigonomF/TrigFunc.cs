using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratedTesting.TrigonomF
{
    public class TrigFunc
    {
        public static double Factorial(uint num) //Факториал
        {
            if (num <= 1)
            {
                return 1d;
            }

            return num * Factorial(num - 1);
        }

        public static double Power(double num, int pow) //Возведение в степень
        {
            double result = 1;
            if (pow == 0)
            {
                return 1;
            }
            for (int i = 1; i <= pow; i++) result = result * num;
            return result;
        }


        public static double Sin(double x, int n = 0, double precision = 1e-10) //Синус
        {
            var t = Power(-1, n) * Power(x, 2 * n + 1) / Factorial((uint)(2 * n + 1));
            if (Abs(t) < precision)
            {
                return t;
            }

            return t + Sin(x, n + 1, precision);
        }

        public static double Cos(double x, int n = 0, double precision = 1e-10) //Косинус
        {
            var t = Power(-1, n) * Power(x, 2 * n) / Factorial((uint)(2 * n));
            if (Abs(t) < precision)
            {
                return t;
            }

            return t + Cos(x, n + 1, precision);
        }

        public static double Abs(double num) //Модуль
        {
            if (num >= 0)
            {
                return num;
            }

            return -num;
        }

        public static double Tan(double x) //Тангенс
        {
            return Sin(x) / Cos(x);
        }

        public static double Ctan(double x) //Котангенс
        {
            return Cos(x) / Sin(x);
        }

        public static double cosec(double x) //Косеканс
        {
            
            return 1 / Sin(x);
        }

        public static double sec(double x) //Косеканс
        {

            return 1 / Cos(x);
        }
    }
}
