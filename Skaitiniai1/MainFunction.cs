using System;
using System.Collections.Generic;
using System.Text;

namespace Skaitiniai1
{
    public class MainFunction
    {
        public float Function(float x)
        {
            float y;
            y = x + 1 - (float)Math.Tan(2 * x);
            //y = x * x - 2 * x - 3;
            return y;
        }

        public float FunctionForTwo(float a, float b)
        {
            float y;
            y = Function(b) - Function(a);
            return y;
        }
    }
}
