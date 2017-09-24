using System;

namespace Skaitiniai1.BisectionKeep
{
    class Bisection
    {
        Variables variables = new Variables();
        BisectionAlgorithm algorithms = new BisectionAlgorithm();
        MainFunction funk = new MainFunction();
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
                DoAlgoritm();
                var check = algorithms.IsRangeSmallerTwoEpsilon(variables.A, variables.B, variables.epsilon);
                if (check || !variables.IsAnswerGood || _iteration >= 100)
                    break;
            }
        }

        public void DoAlgoritm()
        {
            if (!algorithms.CheckInterval(variables.A, variables.B))  //checks interval if signs are different
            {
                var c = algorithms.FindCenterPoint(variables.A, variables.B); //gets center point
                var answer = funk.Function(c);      //gets f(c) answer
                if (algorithms.IsAnswerSmallerEpsilon(answer, variables.epsilon)) //checks if f(c) answer is smaller than epsilon if true stops iteration
                    variables.IsAnswerGood = false;
                if (answer == 0)
                {
                    Print(_iteration++, variables.A, variables.B, c, answer);
                    return;
                }
                if (algorithms.CheckInterval(c, variables.A)) //check interval signs
                {
                    Print(_iteration++, variables.A, variables.B, c, answer);
                    variables.A = c;  // c and A are on the same side (have same signs)
                }
                else
                {
                    Print(_iteration++, variables.A, variables.B, c, answer);
                    variables.B = c; // c and A have different signs
                }
            }
        }
    }
}
