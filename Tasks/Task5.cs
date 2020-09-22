using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CertTasks.Tasks
{
    class Task5
    {
        public static int[] arr1 = { 0, 1, 2, 3, 4, 5 };

        // with Linq
        public static int SearchNumber(int[] arr, int num)
        {
            if (arr.Contains(num))
                return num;
            else
                return -1;
        }

        // Manual
        public static int SearchNumberManual(int[] arr, int num)
        {
            foreach (int item in arr)
            {
                if (item == num)
                    return item;
            }
            return -1;
        }
    }
}
