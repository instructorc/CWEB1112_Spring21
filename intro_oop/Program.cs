using System;

namespace intro_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, status, region;

            //Declaring an array of objects
            Renter [] renters = new Renter[3];
            int x = 0;
            while(x < renters.Length){

                Console.WriteLine($"For Object instance {(x+1)} enter name ");
                name = Console.ReadLine();

                Console.WriteLine($"For Object instance {(x+1)} enter renter status **Prospective** or Current Renter** ");
                status = Console.ReadLine();

                Console.WriteLine($"For Object instance {(x+1)} enter renter preferred region East, West or North ");
                region = Console.ReadLine();

                //Instantiating each array object
                renters[x] = new Renter(status, name, region);


                x++;
            }

            for(var i = 0; i < renters.Length; i++){
                System.Console.WriteLine(renters[i]);
            }
  

       
        }
    }
/**
RENTER
    - status: prospective || tenent  --Attribute
    - name: 
    - email:
    - move-date:
    - preferred region:
    - preferred bed_count:
    - preferred bath_count:
**/
    class Renter
    {
        //Attributes
        string status;
        string name;
        string email;
        string moveDate;
        string rent_estimate;

        string preferredRegion;
        int preferredBedCount;
        int preferredBathCount;

        //Default Constructor
        public Renter(){

        }

        //Override the Default Constructor
        public Renter(string aStatus, string aName, string preferredRegion){
            this.status = aStatus;
            this.name = aName;
            this.preferredRegion = preferredRegion;
            getEstimatedRentRange();
        }

        //Behavior Working Methods - Work on behalf of the class.

        //Method to return Rent Range based on preferred region, bed count and bath count 
        private void getEstimatedRentRange(){
            if(this.preferredRegion == "West"){
                rent_estimate = "$1200 - 1299";
            }else if(this.preferredRegion == "East"){
                rent_estimate = "$1300 - 1399";
            }else if(this.preferredRegion == "North"){
                rent_estimate = "$1400 - 1499";
            }else{
                rent_estimate = "N/A";
            }
        }

        

        //ToString
        public override string ToString()
        {
            return String.Format($"Name: {name} Status: {status} Preferred Region: {preferredRegion}  Rent Estimate: {rent_estimate}");
        }
    }

/**
APARTMENTS
    - apart_name:
    - apart_address:
    - apart_floor_count:
    - apart_region:  
    - apart_estimate_range_one_bed:
    - apart_estimate_range_two_bed:
    - apart_estimate_range_three_bed:
**/
  class Apartment
  {







        public override string ToString()
        {
            return String.Format("Coming from Renter Class");
        }

  }
}
