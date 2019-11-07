using System;

namespace Open_Lab_02._01
{
    public class Exercise
    {
        public double[] Create5Numbers()
        {
            return new double[5] { 1.1, 2.3, 5.1, 2.3, 5.1 };
        }

        public double GetSecond(double[] numbers)
        {
            return numbers[1];
        }
    }
}