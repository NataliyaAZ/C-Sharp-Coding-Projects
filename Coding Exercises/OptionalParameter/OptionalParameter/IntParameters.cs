using System;
using System.Runtime.InteropServices;

namespace OptionalParameter
{
    class IntParameters
    {
        public int MathOperation(int num1, int num2=6)
        {
            int result = num1 * num2;
            return result;
        }
    }
}
