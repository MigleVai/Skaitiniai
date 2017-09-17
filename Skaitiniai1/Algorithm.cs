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
            return y;
        }

        public bool CheckInterval(float a, float b)
        {
            if (Function(a) * Function(b) < 0)
                return true;
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
            float range = Math.Abs(a) - Math.Abs(b);
            if (range <= 2 * epsilon)
                return true;
            return false; // range IS smaller than two epsilon
        }

        public bool IsAnswerSmallerEpsilon(float c, float epsilon)
        {
            if (Math.Abs(c) <= epsilon)
                return true;
            return false; // answer IS smaller than epsilon
        }
    }
}
