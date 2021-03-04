using System;

namespace activity6_calendar
{
    class Program
    {
        static void Main(string[] args)
        {
          string [] MONTHS = {"Jan.", "Feb.","Mar.", "Apr.", "May", "Jun","Jul","Aug", "Sept.", "Oct","Nov", "Dec"};
          int MONTH_END = 12;
          int maxCount;
          int FEB_COUNT = 28;
          int THIRTY_DAY_COUNT = 30;
          int MAX_DAY_COUNT = 31;
          int x = 1;
          int i;
          // February 28 days, April, June, Sept. November
          
          //Looping structure that iterat through the month
          while(x <= MONTH_END){
              Console.WriteLine("For " + MONTHS[x-1]);
             //Iterate through the days

             //Decision Making Logic to determine day count
             maxCount = MAX_DAY_COUNT;
             if(x == 2){
                 maxCount= FEB_COUNT;
             }else if(x == 4 || x == 6 || x == 9 || x == 11 ){
                 maxCount = THIRTY_DAY_COUNT;
             }
             i = 1;
             while(i <= maxCount){

                Console.Write(i + "\t");

                 i++;
             } //End of inner Loop
             Console.WriteLine(" ");
              x++;
          }
        }
    }
}
