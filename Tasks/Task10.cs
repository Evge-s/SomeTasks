using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task10
    {
        public static readonly string longStr = "Veryyyyyyyyyyyy loooooooooooong string";
        public static readonly string shortStr = "J J ";
        public static int LastIndexOfLongStr(string str1, string str2)
        {
            if (!string.IsNullOrEmpty(str2))
            {
                return longStr.IndexOf(longStr.Last());
               
            }
            throw new Exception();
        }
    }
}
