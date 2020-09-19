using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task13
    {
        public static string textWithComma = "Text, with. Different symbols!!!";
        public static string longestWord(string text)
        {
            return (from word in text.Split(new char[] { ',', '.', ' ', '!' })
                   orderby word.Length descending
                   select word).First();
        }
    }
}
