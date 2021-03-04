using System;

namespace grading
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATIONS
            string userName, dogName, dogBreed;
            int dogAge, numOfWeeks, dogWeight;
            double total =0;
            const int WEIGHT_LIMIT = 15, WEIGHT_LIMIT_THIRTYONE = 31, WEIGHT_LIMIT_EIGHT = 80, SEVENTY_FIVE_FEE = 75, FIFTY_FIVE_FEE = 55, ONEZEROFIVE_FEE = 105, ONETWENTYFIVE_FEE = 125;
            string EXIT = "EXIT"; //Sentinal Value

           Console.WriteLine("Welcome to the Minneapolis Dog Boarding Company! Please enter your username: ");
            userName = Console.ReadLine(); //Primer

            while(userName != EXIT){
                Console.WriteLine($"Nice to have you back {userName}! What is your dog's name?");
                dogName = Console.ReadLine();
                Console.WriteLine($"Okay thank you and what is {dogName}'s breed?");
                dogBreed = Console.ReadLine();
                Console.WriteLine($"What is {dogName}'s age?");
                dogAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"And how many weeks will {dogName} be with us?");
                numOfWeeks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Our last question for you is how much does {dogName} weigh?");
                dogWeight = Convert.ToInt32(Console.ReadLine());
                if (dogWeight < WEIGHT_LIMIT){
                    total = 55 * numOfWeeks;

                }
                else{
                    if (dogWeight < WEIGHT_LIMIT_THIRTYONE){
                        total = 75 * numOfWeeks;
                        
                    }else
                        if (dogWeight < WEIGHT_LIMIT_EIGHT){
                            total = 105 * numOfWeeks;
                        
                        }   
                    }
                    if(total > 125){
                        total = total *(1 + .02);
                        Console.WriteLine($"The total cost for {dogName}'s care will be {total}!  This is your total with a 2% discount");
                    }else{
                        Console.WriteLine($"The total cost for {dogName}'s care will be {total}!");
                    }

                    Console.WriteLine("To enter a new cost evaluation enter a name or type in EXIT to leave program.");
                    userName = Console.ReadLine(); //Primer

                }//End of while Loop
                Console.WriteLine("Program has ended!");
            }//End of main method
    

        }
    
}
