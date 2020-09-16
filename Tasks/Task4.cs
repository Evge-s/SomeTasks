using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CertTasks.Tasks
{
    class Task4
    {
        public static int[] arr1 = { 0, 1, 2, 3, 5 };

        public static int MissingNumberByContainsArray(int[] arr)
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!arr.Contains(i))
                {
                    res = i;
                    break;
                }
            }
            return res;
        }

        public static int MissingNumberBySortList(int[] arr)
        {
            List<int> sortedArr = arr.ToList();
            sortedArr.Sort();

            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (sortedArr.ElementAt(i) != i)
                    res = i;
            }
            return res;
        }
    }
}
