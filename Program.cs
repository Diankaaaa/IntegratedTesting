using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratedTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TrigonomF.TrigFunc.Power(5,2));
            Console.WriteLine(Math.Pow(5,2));
            

            double b = Math.Log(1024, 2);// - 1 способ вычислить логарифм с произвольным основанием
            double d = Math.Log(1024)/Math.Log(2); //2 способ вычислить логарифм с произвольным основанием
            

            Console.WriteLine("{0} {1}",b,d);
            Console.WriteLine(Math.Log(100));
            Console.WriteLine(TrigonomF.TrigFunc.Power(5,2));
            Console.WriteLine("\n\n");
            Console.WriteLine("Введите х: ");
            double x = double.Parse(Console.ReadLine());
            double result = 0;
            if(x <= 0)
            {
               result = ((((TrigonomF.TrigFunc.Tan(x) / TrigonomF.TrigFunc.Tan(x)) + TrigonomF.TrigFunc.Sin(x)) + TrigonomF.TrigFunc.Tan(x)) * TrigonomF.TrigFunc.cosec(x)) * TrigonomF.TrigFunc.sec(x);
            }
            else
            {
                //log10 X = ln(x)/ln10 - формула перехода
                result = ( (Log.LogFunc.translate(2) - Log.LogFunc.translate(2)* Log.LogFunc.translate(10))/ ((Log.LogFunc.translate(3)) / Log.LogFunc.translate(5) - Log.LogFunc.Ln1MinusX(x))  + (((Log.LogFunc.Ln1MinusX(x)) / (Log.LogFunc.translate(10) / Log.LogFunc.translate(2))) * Log.LogFunc.translate(3)) * ((Log.LogFunc.translate(2)*(Log.LogFunc.translate(3)* Log.LogFunc.translate(3))) / (Log.LogFunc.translate(10) * Log.LogFunc.translate(2) * (Log.LogFunc.translate(5)* Log.LogFunc.translate(5))) ));
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
