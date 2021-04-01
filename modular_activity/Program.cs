using System;

namespace modular_activity
{
    class Program
    {
        static void Main(string[] args)
        {
            //GlOBAL DECLARATIONS
            string [] FOOD_ITEMS = {"Nuts", "Fish", "Lentils", "Whole Grains", "Beans", "Olive Oil", "Eggs", "Yogurt"};
            int selectedItemNumber;

            selectedItemNumber = selectItems(FOOD_ITEMS);
            displayPickUpItem(selectedItemNumber, FOOD_ITEMS);          
        }//End the main method

        //Method that outputs each food item.  Pass the array to the method.  Method returns void
        static void displayItems(string[] arr){

            for(var x = 0; x < arr.Length; x++){
                System.Console.WriteLine($"Input {x} for {arr[x]}");
            }
        }
        //Method is going to allow the end user to select an item.  Return the item to the main method. Pass the array to the method.
        static int selectItems(string[] arr){
            int itemNumber;

            displayItems(arr); //Nested Methon
            System.Console.WriteLine("Please input the number of the item you would like to pick up from the grocery store");
            itemNumber = Convert.ToInt32(Console.ReadLine());

            return itemNumber;
        }
        //Create a method that would output the item.
        static void displayPickUpItem(int itemNum, string[] arr){
            Console.WriteLine(arr[itemNum]);
        }

    }

    
}
