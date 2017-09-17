using System;

namespace Skaitiniai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iteration - A - B - Range - F(range) - B-A");
            Bisection bi = new Bisection();
            bi.SetVariables(0.7f, 2.5f, 0.0001f);
            bi.DoBisection();
            Console.WriteLine("DONE");
            Console.ReadLine();        
        }
    }
}
