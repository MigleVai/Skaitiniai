using System;
using System.Collections.Generic;
using System.Text;

namespace Skaitiniai1.BisectionKeep
{
    class BisectionAlgorithm
    {
        MainFunction funk = new MainFunction();

        public bool CheckInterval(float a, float b)
        {
            if (Math.Sign(funk.Function(a)) == Math.Sign(funk.Function(b)))
                return true;  //it should be
            return false;
        }

        public float FindCenterPoint(float a, float b)
        {
            float c;
            c = (a + b) / 2;
            return c;
        }

        public bool IsRangeSmallerTwoEpsilon(float a, float b, float epsilon)
        {
            float range = a - b;
            if (Math.Abs(range) <= 2 * epsilon)
                return true; // range IS smaller than two epsilon - should stop
            return false; 
        }

        // |cn - c*| < epsilon ???

        public bool IsAnswerSmallerEpsilon(float answer, float epsilon)
        {
            if (Math.Abs(answer) <= epsilon)
                return true; // answer IS smaller than epsilon - should stop
            return false; 
        }
    }
}
