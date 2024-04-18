using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StandardMessages
    {
        public static void welcome(){
            Console.WriteLine("Welcome to my application");
        }

        public static void EndApplication(){
            Console.ReadLine();
        }

        
        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid { fieldName }!");
        }
    }
}