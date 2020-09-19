using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CertTasks.Tasks
{
    class Task10
    {
        public static string text = "Some text for test task, about the string contains another string";
        public static string str = "ome ";

        public static int GetIndex(string text, string str)
        {
            return text.IndexOf(str.Last());
        }

        // Pass
        public static int GetIndexManual(string text, string str)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == str[0])
                {
                    // Some Code
                }
            }
            return 1;
        }
    }
}
