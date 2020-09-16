using CertTasks.Tasks;
using System;

namespace CertTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Task2.ConvertData(Task2.data));

            foreach (var item in Task2.ConvertToEnumerable(Task2.data))
            {
                Console.WriteLine(item);
            }
        }
    }
}
