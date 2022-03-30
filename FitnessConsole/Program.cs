using AppBusinessLogic.Controller;
using System;

namespace FitnessConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the NikFit app");

            Console.WriteLine("Enter username: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your gender: ");
            string gender = Console.ReadLine();

            Console.WriteLine("Enter Date of Birth: ");
            var birthdate = DateTime.Parse(Console.ReadLine()); // will refactor this line

            Console.WriteLine("Enter Weight: ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Height: ");
            double height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthdate, weight, height);
            userController.Save();

        }
    }
}
