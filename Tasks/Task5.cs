using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CertTasks.Tasks
{
    class Task5
    {
        public static int[] arr1 = { 0, 1, 2, 3, 4, 5 };

        public static int SearchNumber(int[] arr, int num)
        {
            if (arr.Contains(num))
                return num;
            else
                return -1;
        }
    }
}
