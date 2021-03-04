using System;
using ConsoleTables;
using System.Linq;

namespace testpack
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = new ConsoleTable("one", "two", "three", "four");
            table.AddRow(1, 2, 3, 4)
                .AddRow("this line should be longer", "yes it is", "oh", "fourth Column");

            table.Write();
            
            Console.WriteLine();



            Console.ReadKey();         
        }
    }
}
