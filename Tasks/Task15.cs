using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task15
    {
        public static int[] array = { 1, 2, 3, 5, 5 };
        public static Dictionary<int,int> groupArray(int[] array)
        {
            var groupArray = from num in array
                             group num by num into numbers
                             select numbers;
            return groupArray.ToDictionary(b => b.Key, b => b.Count());
        }

    }
}
