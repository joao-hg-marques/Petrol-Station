using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PetrolStaion3
{
    class Staff
    {
        //Random Number Generator, created to assign number plates of car
        static Random rng = new Random();

        //local variable which is not used. It was created just to give an attribute to this class, in this case, 'Name' of Staff.
        private string name;
               
        //This method allows to check how many vehicles are in queue, waiting to fuel.     
        public static void StaffRecord()
        {
            //relating vehicle class with staff class. It allows to record every vehicle assigned.
            Vehicle v;

            //Giving a user friendly view. The color of leters will be white
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("VEHICLES WAINTING");
            for (int i = 0; i < TransactionsList.vehicles.Count; i++)
            {
                //relating the variable "v" with another class 'TransactionsList', in order to obtain a record.
                v = TransactionsList.vehicles[i];
                
                //The Random Number Generator is used to plot the registration number.
                Console.WriteLine("#{0} Vehicle waiting|| Vehicle Plates JH{1}GM", i + 1, v.PlatesNumber + rng.Next(1,999));
            }

        }
        //Method created to run the fucntionality of pumps.
        public static void PumpsMap()
        {
            //relating the local varialble 'p' with Pumps class. It will allow to make pumps working, assigning and releasing vehicles.
            Pumps p;
            

            Console.WriteLine("MAP OF PUMPS");
            
            for (int i = 0; i < 9; i++)
            {
                //Giving direct relashionshp with TransactionsList class. It will be possible to record all transactions.
                p = TransactionsList.pumps[i];
               

                //Colouring the leters, just to make more user friendly
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" PUMP {0}", i + 1);
                
                if (p.IsFree())
                {
                    //Giving a user friendly view. If any pump is availbale, give the colour 'green' to the word 'AVAILABLE'
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("---AVAILABLE---");
                    
                }
                else
                {

                    
                    //Giving a user friendly view. If any pump is availbale, give the colour 'red' to the word 'In USE'
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("---IN USE---");
                    
                                                           
                }
          
            }
        }
       



}    }
    

    

        


    

