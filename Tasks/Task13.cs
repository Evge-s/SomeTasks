using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CertTasks.Tasks
{
    class Task13
    {
        public static string textWithComma = "Text, with. Different symbols!!!";

        // Linq with Max()
        public static string GetTheLongestWord(string text)
        {
            var temp = text.Split(new char[] { ',', '.', ' ', '!' });
            return temp.Where(str => str.Length == temp.Max(str => str.Length)).First();
        }

        // Linq with orderby
        public static string TheLongestWord(string text)
        {
            return (from word in text.Split(new char[] { ',', '.', ' ', '!' })
                    orderby word.Length descending
                    select word).First();
        }
    }
}
