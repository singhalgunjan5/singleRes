// See https://aka.ms/new-console-template for more information

// The Single Responsibility Principle (SRP) is one of the five SOLID principles 
// of object-oriented programming and design.It states that a class should have only one reason to change,
// meaning it should have only one responsibility or job.

using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.welcome();
            Person user = PersonDataCapture.Capture();
            bool isValidUser = PersonValidator.Validate(user);
            if (!isValidUser)
            {
                StandardMessages.EndApplication();
                return;
            }
            AccountGenerator.Generate(user);

        }
    }
}