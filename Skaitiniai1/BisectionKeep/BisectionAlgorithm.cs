using System;

namespace Skaitiniai1.BisectionKeep
{
    class BisectionAlgorithm
    {
        MainFunction funk = new MainFunction();  //We get function from this

        public bool CheckInterval(float a, float b)  // interval has same signs at each end
        {
            if (Math.Sign(funk.Function(a)) == Math.Sign(funk.Function(b)))
                return true;  //signs are the same
            return false;
        }

        public float FindCenterPoint(float a, float b)  //returns center point of the interval
        {
            float c;
            c = (a + b) / 2;
            return c;
        }

        public bool IsRangeSmallerTwoEpsilon(float a, float b, float epsilon) //checks if range is smaller than 2epsilon
        {
            float range = a - b;
            if (Math.Abs(range) <= 2 * epsilon)
                return true; // range IS smaller than two epsilon - should stop
            return false; 
        }

        public bool IsAnswerSmallerEpsilon(float answer, float epsilon) 
        {
            if (Math.Abs(answer) <= epsilon)
                return true; // answer IS smaller than epsilon - should stop
            return false; 
        }
    }
}
