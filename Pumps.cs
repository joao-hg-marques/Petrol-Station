using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PetrolStaion3
{
    class Pumps
    {
        //Setting a Random Number Generator for PumpID.
        static Random rng = new Random();
        public Vehicle vehicleInPump = null;

        //Private Attributes
        private static int pumpID;
        private string typeOfFuel;
        private int number;

        //Converting the private attributes into public.
        public static int PumpID
        {
            get
            {
                return pumpID;
            }
            set
            {
                pumpID = value;
            }
        }
        public string TypeOfFuel
        {
            get
            {
                return typeOfFuel;
            }
            set
            {
                typeOfFuel = value;
            }
        }
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        //Building constructores.It will allow to interaction
        public Pumps(string tof)
        {
            TypeOfFuel = tof;
            Number = pumpID;
            PumpID = rng.Next(1, 9); //Previously declared above

        }

        //Method created to assign vehicles when a pump is free, giving a bool condition. (False or True)
        public bool IsFree()
        {
            //null==Available pump, not null means the pump is busy.
            return vehicleInPump==null;
        }
           
        //Creating a timer. Every car, must be in each pump for 18 seconds
        public void CreateVehicle (Vehicle v)
        {
            vehicleInPump = v;
            Timer timer = new Timer(18000);
            timer.Interval += v.TankSize;
            timer.AutoReset = false; //It will not repeat
            timer.Elapsed += FreeVehicle;
            timer.Enabled = true;
            timer.Start();
        }

        //Code base on Petrol Skeleton. When the vehicle is fuelled, it leaves the pump, releasing one vehicle and adding a new one.
        public void FreeVehicle(object sender,ElapsedEventArgs e)
        {
            Vehicle vehicle = new Vehicle("",0);
            vehicle.TankSize = vehicleInPump.TankSize;
            vehicle.PlatesNumber = vehicleInPump.PlatesNumber;
            TransactionsList.vehicles.Add(vehicle);
            vehicleInPump = null;
        }
    }
}
