using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AccountGenerator
    {
        public static void  Generate(Person user)
        {
            Console.WriteLine("Your user name is " + user.FirstName + " " + user.LastName);
        }
    }
}