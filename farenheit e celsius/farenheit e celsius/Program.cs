using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farenheit_e_celsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double C, aux, ti, tf, F;

            Console.WriteLine("Digite a temperatura inicial");
            ti = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a temperatura final");
            tf = double.Parse(Console.ReadLine());
            if(ti > tf)
            {
                aux = ti;
                ti = tf;
                tf = aux;
            }
            
            for(F = ti; F <= tf; F++)
            {
                C = 5 * (F - 32) / 9;
                Console.WriteLine(F + "ºF = " + Math.Round(C,1) + "ºC");
            }
            Console.ReadKey();
        }
    }
}
