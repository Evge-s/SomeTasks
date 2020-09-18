using CertTasks.Tasks;
using System;
using System.Collections.Generic;

namespace CertTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Task12.FindSumLinq("11 + 341 + 5"));
            Console.WriteLine(Task12.FindSumManual("11 + 341 + 5"));
        }
    }
}
