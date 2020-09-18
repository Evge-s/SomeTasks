using CertTasks.Tasks;
using System;

namespace CertTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Task9.PowNumMath(2, -3));
            Console.WriteLine(Task9.PowNumManual(2, -3));
            Console.WriteLine(Task9.PowNumRecursion(2, -3));


        }
    }
}
