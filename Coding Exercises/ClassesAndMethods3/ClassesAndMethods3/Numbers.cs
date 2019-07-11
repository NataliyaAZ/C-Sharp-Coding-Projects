using System;


namespace ClassesAndMethods3
{
    class Numbers
    {
        public int Operation1(int num)
        {
            int result = num * 102;
            return result;
        }

        public decimal Operation2(decimal num)
        {
            decimal result = num * 102;
            return result;
        }

        public int Operation3(string num)
        {
            int number = Convert.ToInt32(num);
            int result = number * 102;
            return result;
        }
    }
}
