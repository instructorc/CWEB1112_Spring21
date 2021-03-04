using System;
using System.Collections.Generic;

namespace data_structures_activity1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dep;
            int[] counts = {0, 0, 0, 0, 0, 0};
            int QUIT = 999;
            Console.WriteLine($"Enter dependents or {QUIT} to quit");
            dep = Convert.ToInt32(Console.ReadLine());

            while(dep != QUIT){
                counts[dep] = counts[dep] + 1;
                Console.WriteLine($"Enter dependents or {QUIT} to quit");
                dep = Convert.ToInt32(Console.ReadLine());             

            }

            Console.WriteLine("Dependents Count");
            dep =0;
            while(dep < counts.Length){
                Console.WriteLine($"{dep} employees with {counts[dep]} dependents");
                dep+=1;
            }
            Console.WriteLine("Program has ended");

        }
    }
}
