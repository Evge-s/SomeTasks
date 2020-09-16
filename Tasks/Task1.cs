using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CertTasks.Tasks
{
    class Task1
    {
        public static int[] array1 = { 1, 2, 3, 4, 5 };
        public static int[] array2 = { 5, 4, 3, 2, 1 };

        public static bool ArrReverseFor(int[] arr1, int[] arr2) // 1
        {
            if (arr1.Length == 0)
                return false;
            if (arr1.Length != arr2.Length)
                return false;
            for (int i = 0, j = arr1.Length - 1; i < arr1.Length; i++, j--)
                if (arr1[i] != arr2[j])
                    return false;
            return true;
        }

        public static bool ArrReverseT(int[] arr1, int[] arr2) // 2
        {
            return Enumerable.SequenceEqual(arr1, arr2.Reverse());
        }
    }
}
