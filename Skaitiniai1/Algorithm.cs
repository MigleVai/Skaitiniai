using System;
using System.Collections.Generic;
using System.Text;

namespace Skaitiniai1
{
    class Algorithm
    {
        public float Function(float x)
        {
            float y;
            y = x + 1 - (float)Math.Tan(2 * x);
            //y = x * x - 2 * x - 3;
            return y;
        }

        public bool CheckInterval(float a, float b)
        {
            if (Function(a) * Function(b) < 0)
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
