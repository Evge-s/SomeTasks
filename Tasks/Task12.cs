using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CertTasks.Tasks
{
    class Task12
    {
        // Linq
        public static int FindSumLinq(string numbers) 
        {
            return Array.ConvertAll(numbers.Split('+'), num => int.Parse(num)).Sum();
        }

        // Manual
        public static int SumOfDigits(string str)
        {
            if (str == null || str.Length == 0)
            {
                return 0;
            }

            int sum = 0;
            string[] splittedArr = str.Split('+');
            foreach (var item in splittedArr)
            {
                sum += int.Parse(item);
            }
            return sum;
        }

        // List<> with Sum(
        public static int FindSumLinqFor(string str)
        {
            if (str == null || str.Length == 0)
            {
                return 0;
            }

            string[] temp = str.Split("+");

            List<int> digits = new List<int>(); 
            foreach (var item in temp)
            {
                digits.Add(int.Parse(item));
            }
            return digits.Sum();
        }
    }
}
