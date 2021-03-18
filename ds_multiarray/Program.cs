using System;

namespace ds_multiarray
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATIONS
            //2-dimensional Array
            int [ , ] RENT_BY_FLOOR_AND_BDRMS = {
                {350, 390, 435},
                {400, 440, 480},
                {475, 530, 575},
                {600, 650, 700},
                {1000, 1075, 1150}
            };

            int floorNumber, aptRoomCount;

            double rent;

            Console.WriteLine("Please input your desired apartment floor");
            floorNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input your desired room apartment room count");
            aptRoomCount = Convert.ToInt32(Console.ReadLine());


            rent = RENT_BY_FLOOR_AND_BDRMS[floorNumber, aptRoomCount];

            Console.WriteLine($"Your rent is {rent.ToString("c")}");

            //Target Center Seating Chart

         
        }
    }
}
