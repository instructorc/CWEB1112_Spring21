using System;

namespace method_activity
{
    class Program
    {
        static void Main(string[] args)
        {   
            //DECLARATIONS
            int term, valueTwo, sumTotal, multiTotal;
            Console.WriteLine("This program will have you put in a term value and return the fibonacci sequence");
            term = getTermValue();

            for(var x = 0; x < term; x++){
                Console.Write(f(term -x) + "\t");
            }
            /**valueOne = getFirstValue();
            valueTwo = getSecondValue();
            sumTotal = getSum(valueOne, valueTwo); //Gets the sum
            multiTotal = getTotalMulti(valueOne, valueTwo);

            output(sumTotal, multiTotal);**/
           
           
        }
        //Method accepts first number and returns interger
        static int getTermValue(){

            try{
                Console.WriteLine("Please enter your term value:");
                return Convert.ToInt32(Console.ReadLine());
            }catch(Exception e){
                getTermValue();
            }
           
        }

        //Method accepts second number and returns interger
        static int getSecondValue(){
            Console.WriteLine("Please enter your second value:");
            return Convert.ToInt32(Console.ReadLine());
        } 

        //Method that accepts 2 interger values and returns the sum
        static int getSum(int value1, int value2){
            return value1 + value2;
        }

        //Method that accepts 2 interger values and returns the numbers multiplied
         static int getTotalMulti(int value1, int value2){
            return value1 * value2;
        }       

        //Method that outputs "Program has ended"
        static void output(int sumTotal, int multiTotal){
            Console.WriteLine($"Sum Total:\t{sumTotal} Numbers Multiplied:\t{multiTotal}");
            Console.WriteLine("Program has ended");
        }
        static int f(int n){
            //DECISION MAKING LOGIC
            if(n <= 2){
                return 1;
            }else{
                return f(n-1) + f(n-2);
            }



        }
    }
}
