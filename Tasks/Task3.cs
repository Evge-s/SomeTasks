using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CertTasks.Tasks
{
    class Task3
    {
        public static int data = 3542;

        public static string ConvertToString(int num)
        {
            string buff = num.ToString();
            string result = string.Empty;
            for (int i = 0; i < buff.Length; i++)
            {
                result += buff[i];
                for (int j = 0; j < buff.Length-(i+1); j++)
                {
                    result += "0";
                }
                if (i != buff.Length -1)
                    result += ", ";
            }
            return result;
        }

        // for return IEnumerable  result
        public static IEnumerable<int> ConvertToEnumerable(int num)
        {
            string buff = num.ToString();
            int[] result = new int[buff.Length];

            for (int i = 0; i < buff.Length; i++)
            {
                string temp = string.Empty;
                for (int j = i+1; j < buff.Length; j++)
                {
                    temp += "0";
                }
                string str = buff[i] + temp;
                result[i] = Int32.Parse(str);
            }
            return result;            
        }


        public static string ExtendedViewOfNumber(long number) /// ALL THIS JUST USING LINQ
        {
            string str = number.ToString();
           return String.Join(", ", str
                .Select((x, i) => char.GetNumericValue(x) * Math.Pow(10, str.Length - i - 1))
                .Where(x => x > 0));
        }
    }
}
