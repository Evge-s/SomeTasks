using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CertTasks.Tasks
{
    class Task8
    {
        public static char[] symbols = { ' ', '.', ',', '?', '!', ';', '-' };
        public static string text = "Some text for test task about the longest word; and, with many symbols! after.Every-word!";
        
        // also can be used
        // text.Split(' ', '.', ',', '?', '!', ';', '-');        
        // text.Split(new char[] { ' ', '.', ',', '?', '!', ';', '-' });

        // Linq
        public static string TheLongestWordLinq(string text)
        {
            string[] buff = text.Split(symbols);
            return buff.OrderByDescending(str => str.Length).First();
        }       
        
        // Manual
        public static string TheLongestWordManual(string text)
        {
            List<string> buff = new List<string>();

            // manual split
            string temp = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (!symbols.Contains(text[i]))
                    temp += text[i];
                else
                {
                    if (!string.IsNullOrEmpty(temp))
                        buff.Add(temp);
                    temp = string.Empty;
                }
            }

            // finding the longest word
            string result = string.Empty;
            for (int i = 1; i < buff.Count(); i++)
            {
                if (result.Length < buff[i].Length)
                    result = buff[i];
            }
            return result;
        }
    }
}
