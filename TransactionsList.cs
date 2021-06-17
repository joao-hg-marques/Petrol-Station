using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PetrolStaion3
{
    class TransactionsList
    {
        //Setting a timer. If there is not a timer, the system will not work. Pumps will not work, and cars are not added to pumps.
        private static Timer timer;
        
        //Creating a List to record all vehicles
        public static List<Vehicle> vehicles;

        //creating a List to record all pumps. It will allow to know, which pumps are working
        public static List<Pumps> pumps;
        public static Random random = new Random();

        //Method created to give a better organization. This method is going to start the pumps. Based on the Petrol Skeketon. 
        //It gathers code of other two methods above and then it will be on the main program.
        public static void StartProcess()
        {
            //Two methods created below, will ensure vehicles being added and pumps will be working, as well.
            StartPumps();
            StartVehicles();

        }

        //Setting timer to assign car to pumps
        private static void StartVehicles() 
        {

            vehicles = new List<Vehicle>();
            timer = new Timer();
            timer.Interval = 1500;
            // keep repeting every 1.5 seconds. A new car is created every 1.5 seconds
            timer.AutoReset = true;
            timer.Elapsed += AddVehicle;
            timer.Enabled = true;
            timer.Start();
        }

        //Adding vehicles to pumps. Code base on petrol Skeleton
        private static void AddVehicle(object sender, ElapsedEventArgs e)
        {
           if (TransactionsList.vehicles.Count >=3)
           {
             return;
           }
           //Timer for add vehicles. Code base on Petrol skeleton
            Vehicle v = new Vehicle("", 10 * 1800);
            vehicles.Add(v);
        }

        //Stating pumps. Code base on petrol Skeleton. This method will star the pumps, and vehicles are going to start to be added into them.
        private static void StartPumps()
        {
            pumps = new List<Pumps>();
            Pumps p;
            for (int i = 0; i < 9; i++)
            {
                p = new Pumps("PUMP");
                pumps.Add(p);

            }
        }

        //Code base on Petrol Skeleton. Vehicles are going to be assign into pumps to fuel.
        public static void AddVehiclesToPump()
        {
            Vehicle v;
            Pumps p;
            if (vehicles.Count == 0)
            {
                return;
            }
            for (int i = 0; i < 9; i++)
            {
                p = pumps[i];
                //If the pump is available, assign vehicle into it.
                if (p.IsFree())
                {
                    //Add first vehicle
                    v = vehicles[0];

                    //Remove vehicle from the wainting list
                    vehicles.RemoveAt(0);

                    //Add into the pump
                    p.CreateVehicle(v);
                }
                if (vehicles.Count == 0) { break; }
            }
        }
    }   
}


    

