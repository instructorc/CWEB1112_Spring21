using System;

namespace grading_a2
{
    class Program
    {
        static void Main(string[] args)
        {
             string[] deptNames = {"Personnel", "Marketing", "Information Technology", 
            "Computer Science", "Sales", "Legal", "Accounting"};
            string NAME = "";
            string EXIT = "EXIT";
            int dept = 0;
            double hourlyRate, numOfHours;
            double SALARY;
            double total1 = 0, total2 = 0, total3 = 0, total4 = 0, total5 = 0, total6 = 0, total7 = 0;
            

            
            Console.WriteLine("Welcome to the payroll generator!");
            Console.WriteLine("Please enter the employee's name:");
            NAME = Console.ReadLine();
            while(NAME != EXIT){
                Console.WriteLine($"What is {NAME}'s department number?");
                dept = Convert.ToInt32(Console.ReadLine());
                if(dept <= deptNames.Length){
                    dept = dept - 1;
                    Console.WriteLine($"What is {NAME}'s hourly rate?");
                    hourlyRate = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"How many hours did {NAME} work?");
                    numOfHours = Convert.ToDouble(Console.ReadLine());
                    SALARY = hourlyRate * numOfHours;
                    Console.WriteLine($"Employee Name: {NAME}");
                    Console.WriteLine($"Employee Department: {deptNames[dept]}");
                    Console.WriteLine($"Employee Salary: {SALARY}");
                    if((dept + 1) == 1){
                        total1 = total1 + SALARY;
                    }
                    if((dept + 1) == 2){
                        total2 = total2 + SALARY;
                    }
                    if((dept + 1) == 3){
                        total3 = total3 + SALARY;
                    }
                    if((dept + 1) == 4){
                        total4 = total4 + SALARY;
                    }
                    if((dept + 1) == 5){
                        total5 = total5 + SALARY;
                    }
                    if((dept + 1) == 6){
                        total6 = total6 + SALARY;
                    }
                    if((dept + 1) == 7){
                        total7 = total7 + SALARY;
                    }
                    Console.WriteLine("Enter another name to continue, or EXIT to generate report.");
                    NAME = Console.ReadLine();


                }else{
                    Console.WriteLine("Department number not found. Please Enter a number between 1 and 7.");
                }
            }
                Console.WriteLine($"Personnel Payroll: {total1}");
                Console.WriteLine($"Marketing Payroll: {total2}");
                Console.WriteLine($"Information Technology Payroll: {total3}");
                Console.WriteLine($"Computer Services Payroll: {total4}");
                Console.WriteLine($"Sales Payroll: {total5}");
                Console.WriteLine($"Legal Payroll: {total6}");
                Console.WriteLine($"Accounting Payroll: {total7}");
                
        }
    }
}
