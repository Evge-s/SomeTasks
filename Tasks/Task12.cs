using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CertTasks.Tasks
{
    class Task12
    {
        // Linq
        public static int FindSumLinq(string numbers) 
        {
            return Array.ConvertAll(numbers.Split('+'), num => int.Parse(num)).Sum();
        }

        // Linq with foreach
        public static int FindSumLinqFor(string str)
        {
            string[] temp = str.Split("+");

            // can be changet to int like Manual adding (+=)
            List<int> digits = new List<int>(); 
            foreach (var item in temp)
            {
                digits.Add(int.Parse(item));
            }
            return digits.Sum();
        }

        // Manual 
        public static int FindSumManual(string str)
        {
            // A temporary string  
            string temp = "";

            // holds sum of all numbers 
            // present in the string  
            int sum = 0;

            // read each character in input string  
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                // if current character is a digit  
                if (char.IsDigit(ch))
                    temp += ch;

                // if current character is an alphabet  
                else
                {
                    // increment sum by number found earlier  
                    // (if any)  
                    sum += int.Parse(temp);

                    // reset temporary string to empty  
                    temp = "0";
                }
            }

            // atoi(temp.c_str()) takes care of trailing  
            // numbers  
            return sum + int.Parse(temp);
        }
    }
}
