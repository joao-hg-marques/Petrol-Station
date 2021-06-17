using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStaion3
{
    class Vehicle
    {
        //Static random generator. Allowing a rng for a value. In this case, for the tankSize.
        static Random rng = new Random();

        //Declaring private atributtes
        private string fuelType;
        private static double plates;
        private double tankSize;
        private double platesNumber; 
        private string platesNumbers;
        private int fuelCapacity;
        private int pumpNumber;
        private double payforFuel;
        //Private variables declared after the visual studio has given a solution. Apparently these variables needed to be created to allow vehicle "comunicate" with the transacionList class
        //A error solution given by visual studio.
        private string v1;
        private int v2;

        //Converting into public
        public double PayForFuel
        {
            get
            {
                return payforFuel;
            }
            set
            {
                payforFuel = value;
            }
        }
        public string FuelType
        {
            get
            {
                return fuelType;
            }
            set
            {
                fuelType = value;
            }
        }

        //Declaring a global variable to assign plates number to vehicles
        public static double Plates     
        {
            get
            {
                return plates;
            }
            set
            {
                plates= value ;
            }
        }
        public double TankSize
        {
            get
            {
                return tankSize;
            }
            set
            {
                //Random generator, to fuel deposits from 1l to 150l.
                tankSize =rng.Next(1,150) ;
            }
        }
        public double PlatesNumber
        {
            get
            {
                return platesNumber;
            }
            set
            {
                platesNumber = plates;
            }
        }
        
        //Constructors. Allows arguments being more flexible.
        public Vehicle(string ft, double ts, double pff,string platesNumbers, string fuelType, int fuelCapacity, int pumpNumber,double platesNumber)
        {
            FuelType = ft;
            TankSize = ts;
            PlatesNumber=Plates++;
            PayForFuel = pff;

        }

        //Constructor created after Visual studio has been given a solution fot the following error: There is no argument given that corresponds to the required formal parameter (pff=PayForFuel)
        public Vehicle(string platesNumbers, string fuelType, int fuelCapacity, int pumpNumber)
        {
            this.platesNumbers = platesNumbers;
            this.fuelType = fuelType;
            this.fuelCapacity = fuelCapacity;
            this.pumpNumber = pumpNumber;
        }

        //Constructor made to give vehicle 2 arguments. Error solution made by visual studio
        public Vehicle(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

    }
}
                   






