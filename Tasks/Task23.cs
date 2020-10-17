/*1.  Задано 2 посортованих масиви. Очікуваний результат: посортований масив, який складатиметься з перших двох. 
	Обходити масиви можна лише раз. Не застосовувати вбудовані ф-ції сортування

	Приклад вхідних даних:
	[2,4,8,34] 
	[2,5,6,8,12,42,54] 

	Очікуванеий результат:
	[2,2,4,5,6,8,8,12,34,42,54]
*/
using System.Collections.Generic;

namespace CertTasks.Tasks
{
    class Task23
    {
        public static int[] AddSortArrays(int[] first, int[] second)
        {
            // свап вказівників, щоб не виходити за межі массиву,   
            // якщо розмір першого буде більший за розмір другого
            if (first.Length > second.Length)
            {
                var temp = second;
                second = first;
                first = temp;
            }

            List<int> res = new List<int>();

            // ітератори
            int i = 0;
            int j = 0;

            // логіка порівняння, та додавання значень до вихідного
            // массиву, за один прохід.
            while (res.Count != first.Length + second.Length)
            {
                if (i < first.Length && first[i] < second[j])
                {
                    res.Add(first[i]);
                    i++;
                }
                else
                {
                    res.Add(second[j]);
                    j++;
                }
            }
            return res.ToArray();
        }
    }
}
