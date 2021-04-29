using System;

namespace assign3_OOP
{
class Program
    {
        static void Main(string[] args)
        {
            int num_days;
            CostCalc[] calculations = new CostCalc[2];
            string code = "No Service Code Entered";
            Console.WriteLine("Welcome! This program will have you input the number of days your pet will be staying with us.");
            for (var x = 0; x < calculations.Length; x++)
            {
                //initialising 
                num_days = welcome();
                Console.WriteLine("Will there be any add-on services? Enter Y for yes or N for no.");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    code = getCode();
                    calculations[x] = new CostCalc(num_days, code);
                }
                else{
                    calculations[x] = new CostCalc(num_days);
                }
                   
                Console.WriteLine(calculations[x]);
            }


        }
        static int welcome()
        {
            int days; //local to method
          
            Console.WriteLine("Please enter the number of days your pet will stay with us. ");
            days = Convert.ToInt32(Console.ReadLine());
            return days;
        }

        static string getCode()
        {
            string code;
            Console.WriteLine("Please enter a Code:  A for bathing and grooming or C for only bathing ");
            code = Console.ReadLine();
            code = checkCode(code);

            return code;
        }

        static string checkCode(string code)
        {
            code = code.ToUpper();
            while (code != "A" && code != "C")
            {
                Console.WriteLine("Invalid Entry - Please enter A for bathing and grooming or C for only bathing");
                code = Console.ReadLine();
                code = code.ToUpper();
            }

            return code;
        }
    }

    class CostCalc
    {
        const double RATE = 75.00, CODE_A = 169.00, CODE_C = 112.00;
        public int DayCount { get; set; }
        public double Total { get; set; }
        public string Code { get; set; } = "N/A";

        //Default Constructor
        public CostCalc() { }

        //Overloaded Constructor - Setting the values for each object instance
        public CostCalc(int dayCount, string code)
        {
            DayCount = dayCount;
            Code = code;
            computeRate();


        }

        public CostCalc(int dayCount)
        {
            DayCount = dayCount;
            computeRate();
        }

        //Working Method that determines Cost
        void computeRate()
        {
            double CODE_A = 169.00, CODE_C = 112.00;
            if (Code == "A")
            {
                Total = CODE_A * DayCount;
            }
            else if(Code == "C")
            {
                Total =CODE_C * DayCount;
            }
            else
            {
                Total = RATE * DayCount;
            }
        }


        //Working Method that validate Code



        public override string ToString()
        {
            return String.Format($"Total amount of days:\t {DayCount} \n Service Code:\t{Code} \n Total for Stay: {Total.ToString("c")}");
        }
    }
}
