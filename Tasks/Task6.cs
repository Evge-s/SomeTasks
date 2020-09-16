using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CertTasks.Tasks
{
    class Task6
    {
        public static int[] arr1 = { 1, 1, 1, 1, 1, 1 };
        public static int[] arr2 = { 2, 2, 2, 2, 2, 2 };

        public static IEnumerable<int> GetArr(int[] arr1, int[] arr2)
        {
            List<int> result = new List<int>();
                for (int i = 0; i < arr1.Length; i++)
                {
                    result.Add(arr1[i]);
                    result.Add(arr2[i]);
                }
            return result;
        }

        public static IEnumerable<int> GetArrWithChecks(int[] arr1, int[] arr2)
        {
            List<int> result = new List<int>();
            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    result.Add(arr1[i]);
                    result.Add(arr2[i]);
                }
            }

            else if(arr1.Length != arr2.Length)
            {
                int size = 0;
                if (arr1.Length > arr2.Length)
                    size = arr1.Length;
                else
                    size = arr2.Length;
                for (int i = 0; i < size; i++)
                {
                    if(i < arr1.Length)
                    result.Add(arr1[i]);
                    if(i < arr2.Length)
                    result.Add(arr2[i]);
                }
            }
            return result;
        }
    }
}
