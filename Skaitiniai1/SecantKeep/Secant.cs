using System;
using System.Collections.Generic;
using System.Text;

namespace Skaitiniai1.SecantKeep
{
    class Secant
    {
        Variables variables = new Variables();
        SecantAlgorithm algorithm = new SecantAlgorithm();
        MainFunction funk = new MainFunction();
        int i = 0;

        public void SetVariables(float a, float b, float epsilon)
        {
            variables.A = a;
            variables.B = b;
            variables.epsilon = epsilon;
        }

        public void MainSecant()
        {
            while (true)
            {
                var temp = algorithm.CountingNewPoint(variables.A, variables.B);
                variables.A = variables.B;
                variables.B = temp;
                temp = funk.Function(variables.B);
                Print(variables.A, variables.B, temp);
                i++;
                if (algorithm.CheckPrecision(variables.A, variables.B, variables.epsilon) || i == 100)
                {
                    break;
                }
            }
        }

        public void Print(float a, float b, float answerB)
        {
            Console.WriteLine(a + " - " + b + " - " + answerB);
        }
    }
}
