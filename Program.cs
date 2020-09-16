using CertTasks.Tasks;
using System;

namespace CertTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Task3.ConvertToString(Task3.data));


            foreach (var item in Task3.ConvertToEnumerable(Task3.data))
            {
                Console.WriteLine(item);
            }
        }
    }
}
