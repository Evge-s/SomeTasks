/*Знайти всі паліндроми, які показує годинник протягом доби. Годинник показує час у 24-годинному форматі.
    Паліндром - слово, число чи набір символів, які однаково читаються зліва направо та справа наліво.	
	Приклад:
	21:12
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace CertTasks.Tasks
{
    class Task25
    {
        public static List<string> Palindroms()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < 24; i++) // години
            {
                for (int j = 0; j < 59; j++) // хвилини
                {
                    string temp = string.Empty;
                    if (i < 10) // додаю 0 якщо година меньше 10
                        temp = "0";
                    temp += i.ToString() + ":";
                    if (j < 10) // додаю 0 якщо хвилина меньше 10
                        temp += "0";
                    temp += j.ToString();
                    // перевірка на паліндром
                    if (temp.SequenceEqual(temp.Reverse()))
                        result.Add(temp);
                }
            }
            return result;
        }
    }
}
