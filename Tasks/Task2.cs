using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CertTasks.Tasks
{
    class Task2
    {
        public static int data = 13345;

        public static string ConvertData(int num) 
        {
            string buff = string.Empty;
            for (int i = 0; i < num.ToString().Length; i++)
            {
                buff += num.ToString()[i];
                if (i != num.ToString().Length - 1)
                {
                    buff += ", ";
                }
            }
            return buff;
        }

        // for return IEnumerable  result
        public static IEnumerable<int> ConvertToEnumerable(int num) 
        {
            string buff = num.ToString();

            var result = buff.Select(digit => int.Parse(digit.ToString()));

            return result;
        }
    }
}
