using System;

namespace grading
{
    class Program
    {
       static void Main(string[] args)
        {
            string customerName, woodName = "PINE", letterColor;
            int orderNum, numOfCharacters,  woodType, characterOverage, colourOfCharacters;
            string EXIT = "EXIT";
            double total =0;
            
            const double MIN_CHARGE=30.00, GOLD_LEAF = 12, OAK_TYPE = 15.00, CHARACTER_CHARGE = 3.00;

            Console.WriteLine("Welcome! Please enter your name. ");
            customerName = Console.ReadLine();

            while(customerName != EXIT){
                Console.WriteLine($"This minimum charge for a sign is {MIN_CHARGE} dollars. There is no additional charge for pine, but an extra $15 for oak.");
                Console.WriteLine("What do you want your sign made out of? Enter 1 for Pine and 2 for oak");
                woodType= Int32.Parse(Console.ReadLine());

                Console.WriteLine("The 1st six characters are included in the mimimum charge. There is a 3 dollar charge for each additional character.");
                Console.WriteLine("How man characters do you want?");
                numOfCharacters = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Select color of sign enter 1 for black, 2 for white, or  3 gold-leaf lettering. There's an additional charge of $12 for gold-leaf lettering.");
                colourOfCharacters = Int32.Parse(Console.ReadLine());

                total = MIN_CHARGE;
                if(woodType == 2){
                    woodName = "OAK";
                    total += OAK_TYPE;
                }
                if(numOfCharacters >=  6){
                    characterOverage = numOfCharacters - 6;
                    total += CHARACTER_CHARGE * characterOverage;
                }

                if(colourOfCharacters == 3){
                    total += GOLD_LEAF;
                }

                //Determine Color
                if(colourOfCharacters == 1){
                    letterColor = "Black";
                }else if(colourOfCharacters == 2){
                    letterColor = "White";
                }else{
                    letterColor = "Gold-Leaf";
                }


                //OUTPUT STATEMENT
                if(woodType == 1 && colourOfCharacters == 3 && numOfCharacters > 10){
                    Console.WriteLine($"Order Number:\t {customerName}\nWoodType:\t {woodName}\nColor Of Characters:\t {letterColor}");
                }else{
                    Console.WriteLine("YOUR QOUTE HAS BEEN EMAILED");
                }

                //PRIMER
                 Console.WriteLine("To determine another sign cost, Please enter your name. or enter EXIT to end program ");
                customerName = Console.ReadLine();

          

                
            } 
            Console.WriteLine("Thanks for using Noah Charles Sign Cost Calculator application");
        }
   
    } 
    
}
