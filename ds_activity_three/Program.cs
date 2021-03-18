using System;

namespace ds_activity_three
{
    class Program
    {
        static void Main(string[] args)
        {
            //DELARATIONS
               //Declare array
            string [] items = {"Nuts", "Fish", "Lentils", "Whole Grains", "Beans", "Olive Oil", "Eggs", "Yogurt"};
            double [] prices = {.59, 2.00, .89, .99, .79, 5.25, 2.99, 1.25};
            
            //Declare Output message
             const string OUTPUT = "Fish Found";

             //Flag variable
             bool isFound = false;

            //initial input
            int x = 0;
            string item="";
            double price =0;
        
            //looping structure
            while(x < items.Length){
                //decision making logic
                if(items[x].ToLower() == "eggs".ToLower()){
                    isFound = true;
                    item = items[x];
                    price = prices[x];
                }
                //increment array
                x++;
            }
            
            if(isFound){
                Console.WriteLine($"You have found {item} for a price of {price.ToString("c")}");
            }
            else{
                Console.WriteLine($"You have found {item} for a price of {price.ToString("c")}");
            }
            /**isFound = true ? Console.WriteLine($"You have found {item} for a price of {price.ToString("c")}") : Console.WriteLine($"You have found {item} for a price of {price.ToString("c")}");**/

            //conclude program
            Console.WriteLine("Program has ended");
        }
    }
}
