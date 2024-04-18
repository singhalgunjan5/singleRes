using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person user = new Person();
            Console.Write("what is your first name ");
            user.FirstName = Console.ReadLine();
            Console.Write("what is your last name ");
            user.LastName = Console.ReadLine();
            return user;
        }
    }
}