using System;
using System.Collections.Generic;

namespace candy_program
{
class Program
    {
        static void Main(string[] args)
        {
            //Two dimensional array
     

            string[,] selection = {
                                     {"Snickers", "Twix", "Mars"},
                                     {"Skittles", "Starburst", "Sour Patch Kids"},
                                     {"Big Red", "Winter fresh", "Trident"}
                                  };
            List<string> candyList = new List<string>();

            //Iterate through the multi-Array and populate the list
            for (var i = 0; i < 3; i++)
            {
                for (var x = 0; x < 3; x++)
                {
                  
                    candyList.Add(selection[i, x]);
                    Console.WriteLine("Name of Candy is {0}", selection[i, x]);
                }
            }

            candyList.Remove("Snickers");

            Console.WriteLine(candyList.Count);
            
     

            //Output the list using lambda Expression
            candyList.ForEach(x => Console.WriteLine(x));
        }
    }
 
}
