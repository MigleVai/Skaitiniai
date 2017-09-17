using System;

namespace Skaitiniai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iteration - A - B - Range - F(range) - B-A");
            Bisection bi = new Bisection();
            bi.SetVariables(0.1f, 0.5f, 0.0001f);
            bi.DoBisection();
            Console.WriteLine("DONE");
            Console.ReadLine();        
        }
    }
}
