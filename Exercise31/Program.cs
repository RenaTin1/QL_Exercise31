using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise31
{
    class Program
    {
        static void Main(string[] args)
        {
           // Serena Tindle-- Exercise #31-- Find the value of an array index
           //TODO:
           //Add input type validation and while loop

            bool ContinueProgram = true;
            while (ContinueProgram == true)
            {
                //Variables
                int Userinput;
                int[] ArrayList = { 2, 8, 0, 24, 51 };

                Console.WriteLine("Enter an index of the array:"); //User Prompt to enter a index
                Userinput = int.Parse(Console.ReadLine());
                if (Userinput > 4) //Validation 
                    Console.WriteLine("Please enter a value between 0-4!");

                Console.WriteLine("The value at index  "+""+Userinput+""+" is "+""+""+ArrayList[Userinput]); //Print to screen

                string input;
                Console.WriteLine("Would you like to continue? (n/y)"); //continue program or no?
                input = Console.ReadLine();
                if (input == "n" || input == "no" || input == "NO" || input == "N")                
                {
                    ContinueProgram = false;
                }

                Console.ReadKey();
            }

        }
    }
}
