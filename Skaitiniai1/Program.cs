using Skaitiniai1.BisectionKeep;
using Skaitiniai1.SecantKeep;
using System;

namespace Skaitiniai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iteration - A - B - Range - F(range) - B-A");
            Bisection bi = new Bisection();
            bi.SetVariables(0.1f, 0.6f, 0.0001f);
            bi.DoBisection();

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("X0 - X1 - f(X1)");
            Secant sec = new Secant();
            sec.SetVariables(0.1f, 0.6f, 0.0001f);
            sec.MainSecant();

            Console.WriteLine("DONE");
            Console.ReadLine();        
        }
    }
}
