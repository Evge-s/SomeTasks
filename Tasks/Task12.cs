using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task12
    {
        public static string numbers = "11+34+5";
        public static int SumOfNumbers(string numbers)  // simple linq exercise
        {
            return Array.ConvertAll(numbers.Split('+'), num => int.Parse(num)).Sum();
        }

    }
}
