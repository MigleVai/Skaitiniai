using System;
using System.Collections.Generic;
using System.Text;

namespace Skaitiniai1.SecantKeep
{
    class SecantAlgorithm
    {
        MainFunction funk = new MainFunction();

        public float CountingNewPoint(float a, float b)
        {
            float newPoint;
            var temp1 = b - a;
            var temp2 = funk.FunctionForTwo(a,b);
            temp1 = temp1 / temp2;
            temp2 = funk.Function(b);
            newPoint = b - temp2 * temp1;
            return newPoint;
        }

        public bool CheckPrecision(float a, float b, float epsilon)
        {
            if (Math.Abs(b - a) < epsilon)
                return true;
            return false;
        }
    }
}
