using CertTasks.Tasks;
using System;

namespace CertTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Task6.GetArr(Task6.arr1, Task6.arr2))
            {
                Console.Write(item + " ");
            }
            
        }
    }
}
