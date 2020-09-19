using CertTasks.Tasks;
using System;
using System.Collections.Generic;

namespace CertTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Task15.getDictionary(Task15.array))
            {
                Console.Write(item.Key + ":" + item.Value + " ");
            }
            Console.WriteLine();
            foreach (var item in Task15.groupArray(Task15.array))
            {
                Console.Write(item.Key + ":" + item.Value + " ");
            }
        }
    }
}
