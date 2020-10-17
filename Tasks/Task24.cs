/*Задано масив, який містить елементи  типу int від 1 до 100. 
	Визначити елемент, що повторюється в масиві, за умови, що в масиві повторюється лише 1 елемент.
*/
using System.Linq;

namespace CertTasks.Tasks
{
    class Task24
    {
        public static int Dublicate(int[] arr)
        {
            // згрупувати елементи массиву, та повернути ключ группи (перше значення)
            // де кількість елементів у группі більше 1.
            return arr.GroupBy(x => x).Where(x => x.Count() > 1).First().Key;
        }
    }
}
