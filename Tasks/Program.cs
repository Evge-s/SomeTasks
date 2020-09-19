using CertTasks.Tasks;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
        
            foreach(var item in Task15.groupArray(Task15.array))
            {
                Console.WriteLine($"{item.Key} - " + $"{item.Value}");
            }


           
        }
    }
}
