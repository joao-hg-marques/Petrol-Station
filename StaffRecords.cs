using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace PetrolStaion3
{
    class StaffRecords
    {
        //setting a Random Number Generator for the number of of litres dispensed.
        static Random rng = new Random();

        //Creating lists that relate the the vehicle class details with the TransactionsList class details 
        static List<TransactionsList> vehicle = new List<TransactionsList>();
        static List<Vehicle> vehicles = new List<Vehicle>();

        //Setting a global double variable, to counting the total litres dispensed.
        public static double totalLitresDispensed = 0;

        //Setting a global interger variable to allowing to count the total served vehicles.
        public static int servedVehicles = 0;

        //Method created that display all transactions made.
        public static void ListOfTransactions()
        {
            //Creating a List of Transactions. It will allow to record all transactions. 
            List<TransactionsList> vehicle = new List<TransactionsList>();

            //Local variables.        
            int stop = 0; //Int Stop. It stops counting when it reaches the value=0
            double costPerLitre = 1.25; //Cost per Litre. This value is going to be multiplied by the number of litres dispensed

            //Giving a user friendly view, by colouring letters with white
            Console.ForegroundColor = ConsoleColor.White;

            //Plotting a list of transactions.
            Console.WriteLine("List Of Transactions");
            if (TransactionsList.vehicles.Count >5)
            {
                stop = TransactionsList.vehicles.Count - 9; //Stopping when it reaches '0'
            }
            //Relating Vehicle class with a local variable, allowing getting info about fuelled vehicles
            Vehicle v;
            

            for (int i = TransactionsList.vehicles.Count -1; i >= stop; i--)
            {

                //Associating the variable v, related with Vehicle Class with TransactionList Class, allowing to plot in this class
                v = TransactionsList.vehicles[i];

                //Local variable created. Allows to know the equal litres dispensed with the cost per litre.
                double totalCost = Math.Round(costPerLitre * v.TankSize, 3);

                //The For loop, displaying all vehicle transactions, showing in which pump has fuelled, the plates, the litres dispensed and the cost of that litres dispensed.
                Console.WriteLine("PUMP {0} |Vehicle Plates:JH{1}GM | Litres dispensed {2} litres |Payment Received £{3}",i+rng.Next(1,8), v.PlatesNumber + rng.Next(1, 999), v.TankSize, totalCost);

                //Dividing the number of litres with the diferent models and the diferent types of fuel.
                if (v.TankSize >= 11 && v.TankSize <= 20) { Console.WriteLine("Model: CAR |  UNLEADED"); }
                if (v.TankSize >= 21 && v.TankSize <= 40) { Console.WriteLine("MODEL: CAR  |  DIESEL"); }
                if (v.TankSize >= 1 && v.TankSize <= 10) { Console.WriteLine("MODEL: CAR  |  LPG"); }
                if (v.TankSize >= 41 && v.TankSize <= 50) { Console.WriteLine("Model: VAN  |  LPG"); }
                if (v.TankSize >= 51 && v.TankSize <= 60) { Console.WriteLine("Model: VAN  |  UNLEADED"); }
                if (v.TankSize >= 61 && v.TankSize <= 80) { Console.WriteLine("Model: VAN  |  DIESEL"); }
                if (v.TankSize >= 81 && v.TankSize <= 85) { Console.WriteLine("Model: HGV  |  LPG"); }
                if (v.TankSize >= 86 && v.TankSize <= 100) { Console.WriteLine("Model: HGV  |  UNLEADED"); }
                if (v.TankSize >= 101 && v.TankSize <= 150) { Console.WriteLine("Model: HGV | DIESEL"); }
             
                Console.WriteLine();
                
            }
        }

        //Method created to give the total transactions made.
        public static void TotalTransactions()
        {
            //The staf's salary per hour.
            double staffHourPay = 2.49;
            //The total salary, per shift, considering shft=8h
            double staffPay;
                staffPay = staffHourPay * 8; // Shift=8h

            //Comission of 1% per litre. 1%==0.01
            double comission = 0.01; //1%

            //Cost per litre. £1.25 x 1l.
            double costPerLitre = 1.25;

            //The total Paymentes received. Sum of all trasactions
            double totalPaymentsReceived = 0;

            //The number of vehicles that did not fuel.
            double vehicleNotFuelled = 0;

            Console.WriteLine("Total Transactions");
           
            //A for loop, that shows the total transactions, adding each transactions.
            for (int i = 0; i < TransactionsList.vehicles.Count; i++)
            {
                //Total litres dispensed= the sum of every litres dispensed of all transactions.
                totalLitresDispensed = totalLitresDispensed+TransactionsList.vehicles[i].TankSize;

                //Total payments received giving by the 'Total Payments received' plus 'Total Litres Dispensed'. It will acumulate the values 
                totalPaymentsReceived = totalPaymentsReceived+ totalLitresDispensed;

                //The vehicles not fuel due to a condition if total litres dispensed==0.
                vehicleNotFuelled = i+1;//Adding '+1' otherwise, it will count from the '0'.

                //Giving a condition to add vehicles not fuelled.
                if (totalLitresDispensed == 0) { Console.WriteLine("", i + 1); } 

            }
            //The result of the condition given above. The local variable 'vehicleNotFuelled' is added up when the codition above is true.
            Console.WriteLine("Vehicles Not Fuelled {0}", vehicleNotFuelled++); 

            //The global variable is added up while vehices have been fuelled.
            Console.WriteLine("Total of Served Vehicles {0}", servedVehicles++);
            Console.WriteLine();

            //The global variable, declared, will give the total litres dispensed. All transaction will be added to this variable.
            Console.WriteLine("Total Litres Dispensed: {0} Litres", Math.Round(totalLitresDispensed));

            //The local variable 'totalPaymentsReceived' plus 'costPerLitre' will determine the total payments made to The Petrol Tryly Station. All values are added up.
            Console.WriteLine("Total Paymentes Received £{0}", totalPaymentsReceived* costPerLitre, 2);// The ',2' means the values have two decimals.
            Console.WriteLine();

            //The Comission of 1%, given by the local variable 'comission' multiply with the 'totalPaymentsReceived' variable.
            Console.WriteLine("Total Comission £{0}",totalPaymentsReceived* comission, 2);//// The ',2' means the values have two decimals.
            Console.WriteLine("Staff Earnings + Comission: £{0}", Math.Round(totalPaymentsReceived++ * comission + staffPay, 2));// The ',2' means the values have two decimals.

        }
        
   
  

        
          
        
             
        
        
           
            
        
    }
}
