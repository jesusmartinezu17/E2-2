using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace sucesionn
{
    class Program
    {
        public static int ffibonacci (int x) {
            int a = 0, b = 0, c = 0, d, cont = 0;
            while (cont < x)
            {
                if (a < 1)
                    a = 1;
                c = a + b;
                b = a;
                a = c;
                cont++;
            }
            d = c;
            return d;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Valor?");
            Stopwatch Tiempo1 = new Stopwatch();
            Stopwatch Tiempo2 = new Stopwatch();
            int X = 1, Y = 0, Cantidad = 0, Fibonacci = int.Parse(Console.ReadLine());
            Tiempo1.Start();
            for (int n = 0; n < Fibonacci; n++)
            {
                Cantidad = X + Y;
                Y = X;
                X = Cantidad;
            }
            Tiempo1.Stop();
            Console.WriteLine("La cantidad es " + Cantidad+ " por medio de un ciclo.");
            Console.WriteLine("El tiempo transcurrido es " + Tiempo1.Elapsed);
            Tiempo2.Start();
            Console.WriteLine("La cantidad es " + ffibonacci(Fibonacci) + " por medio de un método.");
            Tiempo2.Stop();
            Console.WriteLine("El tiempo transcurrido es " + Tiempo2.Elapsed);
            Console.ReadKey();
        }
    }
}
