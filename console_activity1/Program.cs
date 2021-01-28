using System;

namespace console_activity1
{
    class Program
    {
        static void Main(string[] args)
        {
            string favNum;
            
            Console.WriteLine("Enter your your favorite number ");
            favNum = Console.ReadLine();
            double favNumConverted = Double.Parse(favNum);
            Console.WriteLine(favNum.GetType());
            Console.WriteLine(favNumConverted.GetType());
            Console.WriteLine("Yoru Favorite number is: {0}", favNumConverted);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
