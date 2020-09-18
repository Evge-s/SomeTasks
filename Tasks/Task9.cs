using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CertTasks.Tasks
{
    class Task9
    {
        // Match
        public static double PowNumMath(double number, double pow)
        {
            return Math.Pow(number, pow);
        }

        // Manual
        public static double PowNumManual(double number, double pow)
        {
            double result = number;

            if (pow > 0)
                for (int i = 1; i < pow; i++)
                {
                    result *= number;
                }

            else if (pow < 0)
            {
                for (int i = 1; i < pow * -1; i++)
                {
                    result *= number;
                }
                return 1.0 / result;
            }

            return result;
        }

        // Recursion Manual
        public static double PowNumRecursion(int value, int pow)
        {
            if (pow == 0)
                return 1;
            if (pow > 0)
                return value * PowNumRecursion(value, pow - 1);
            return 1.0 / PowNumRecursion(value, -pow);
        }
    }
}
