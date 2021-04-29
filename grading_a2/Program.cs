using System;

namespace grading_a2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Global Declarations
            int num_days;
            double  total;
            //char code;
            string code = "No Service";
        
            //initialising 
           num_days = welcome();
           Console.WriteLine("Will there be any add-on services? Enter Y for yes or N for no.");
            if(Console.ReadLine().ToUpper() == "Y"){
                code = getCode();
               total = computeRate(num_days, code);
            }else{
                total = computeRate(num_days);

            }
            conclude(num_days, code, total);
            
                                    
        }//end main method

        static int welcome(){
            int days; //local to method
             Console.WriteLine("Welcome! This program will have you input the number of days your pet will be staying with us.");
             Console.WriteLine("Please enter the number of days your pet will stay with us. ");
             days = Convert.ToInt32(Console.ReadLine());
             return days;
        }
        static string getCode(){
            string code;
            Console.WriteLine("Please enter a Code:  A for bathing and grooming or C for only bathing ");
            code = Console.ReadLine();
            code = checkCode(code);

            return code;
        }

        static string checkCode(string code){
            code = code.ToUpper();
            while(code != "A" && code != "C"){
                Console.WriteLine("Invalid Entry - Please enter A for bathing and grooming or C for only bathing");
                code = Console.ReadLine();
                code = code.ToUpper();
            }

            return code;
        }

        //Overloaded method with one argument
        static double computeRate(int num_days)
        {
            double  RATE = 75.00;

            //logic for determining the total
            return num_days * RATE;
            
        }

        //Overloaded method with two arguments
        static double computeRate( double num_days, string code)
        {
            double CODE_A = 169.00 , CODE_C= 112.00;
            if(code =="A"){
                return CODE_A * num_days;
            }else{
                return CODE_C * num_days;
            }

        }//End of computRate method with two parameters defined

        static void conclude(int days, string aCode, double aTotal){
            System.Console.WriteLine($"Total amount of days:\t {days} \n Service Code:\t{aCode} \n Total for Stay: {aTotal.ToString("c")}");
        }
    }
}
