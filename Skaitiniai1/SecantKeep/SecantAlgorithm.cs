using System;

namespace Skaitiniai1.SecantKeep
{
    class SecantAlgorithm
    {
        MainFunction funk = new MainFunction();

        public float CountingNewPoint(float a, float b)  //finding new point
        {
            float newPoint;
            var temp1 = b - a;
            var temp2 = funk.FunctionForTwo(a,b);
            temp1 = temp1 / temp2;
            temp2 = funk.Function(b);
            newPoint = b - temp2 * temp1;
            return newPoint;
        }

        public bool CheckPrecision(float a, float b, float epsilon)  //checks if new found point is the approximate answer
        {
            if (Math.Abs(b - a) < epsilon)
                return true; // it is the approximate answer
            return false;
        }
    }
}
