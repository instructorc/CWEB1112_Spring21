using System;
using ConsoleTables;


namespace console_activity1
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = new ConsoleTable("Column One", "Column Two", "three");
                table.AddRow(1, 2, 3)
                    .AddRow("this line should be longer", "yes it is", "oh");

                table.Write();
                Console.WriteLine();
        }
    }
}
