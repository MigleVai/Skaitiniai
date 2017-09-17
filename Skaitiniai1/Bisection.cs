using System;
using System.Collections.Generic;
using System.Text;

namespace Skaitiniai1
{
    class Bisection
    {
        Variables variables = new Variables();
        Algorithm algorithms = new Algorithm();
        int _iteration = 0;

        public void SetVariables(float a, float b, float epsilon)
        {
            variables.A = a;
            variables.B = b;
            variables.epsilon = epsilon;
            variables.IsAnswerGood = true;
        }

        public void Print(int iteration, float a, float b, float range, float funkMiddle)
        {
            Console.WriteLine(iteration + " - " + a + " - " + b + " - " + range + " - " + funkMiddle + " - " + (b - a));
        }

        public void DoBisection()
        {
            while (true)
            {
                var a = algorithms.CheckInterval(variables.A, variables.B);
                Console.WriteLine(a);
                DoAlgoritm();
                if (algorithms.IsRangeSmallerTwoEpsilon(variables.A, variables.B, variables.epsilon) || !variables.IsAnswerGood || _iteration >= 100)
                    break;
            }
        }

        public void DoAlgoritm()
        {

            var c = algorithms.FindCenterPoint(variables.A, variables.B);
            var answer = algorithms.Function(c);
            if (algorithms.IsAnswerSmallerEpsilon(answer, variables.epsilon))
                variables.IsAnswerGood = false;
            //var b = algorithms.IsRangeSmallerTwoEpsilon(variables.A, variables.B, variables.epsilon);
            if (answer == 0)
            {
                Print(_iteration++, variables.A, variables.B, c, answer);
                return;
            }
           // var resultA = algorithms.Function(variables.A);
            if (algorithms.CheckInterval(c, variables.A)) //resultA
            {
                Print(_iteration++, variables.A, variables.B, c, answer);
                variables.A = c;
            }
            else
            {
                Print(_iteration++, variables.A, variables.B, c, answer);
                variables.B = c;
            }
        }
    }
}
