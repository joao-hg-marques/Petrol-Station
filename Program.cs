 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;


namespace PetrolStaion3
{
    class Program
    {
        static void Main(string[] args)
        {
           Process();
        }
        //This method has a timer which will determine the starting program.
        static void Process()
        {
            //This method is going to start the pumps
            TransactionsList.StartProcess();
            //The display will refresh avery 2seconds, updating all transactions.
            Timer timer = new Timer();
            timer.Interval = 2000;
            timer.AutoReset = true;
            timer.Elapsed += Processing;
            timer.Enabled = true;
            timer.Start();
            Console.ReadLine();
            


        }

        //It will run the program, using this method, gathering all classes' operations.
        static void Processing(object sender, ElapsedEventArgs e)
        {
            //It clears the screen, updating the informations, otherwise would give several loops.
            Console.Clear();

            //The title of the Logo/Name of the company

            Console.WriteLine("Petrol");  
            //This method allows to check how many vehicles are in queue, waiting to fuel. Method created on Staff class and put in here.  
            Staff.StaffRecord();
            Console.WriteLine();

            //Method created to run the fucntionality of pumps.
            Staff.PumpsMap();
            Console.WriteLine();

            //Vehicles are going to be assign into pumps to fuel.
            TransactionsList.AddVehiclesToPump();

            //Method created that display all transactions made.
            StaffRecords.ListOfTransactions();

            //Method created to give the total transactions made.
            StaffRecords.TotalTransactions();

                      
   
        }
     
    }
}
