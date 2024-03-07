using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO LAB1!");
            Console.WriteLine("Choose the exercise to display (1, 2, or 3):");
            int choice;

            // Error handling for input parsing
            /*if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }
            
            */
            choice = int.Parse(Console.ReadLine());

            ChooseExercise(choice);

            // Add a pause before exiting (optional)
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            
        }

        static void ChooseExercise(int choice)
        {
            switch (choice)
            {
                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.WriteFibonacci();
                    break;
                case 2:
                    Calculator calculator = new Calculator();
                    calculator.Calcule();
                    break;
                case 3:
                    Console.WriteLine("Exercise 3");
                    break;
                default:
                    Console.WriteLine("Exercise does not exist");
                    break;
            }
        }
    }
}
