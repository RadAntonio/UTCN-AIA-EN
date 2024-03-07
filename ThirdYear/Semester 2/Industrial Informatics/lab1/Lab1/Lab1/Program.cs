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

            Program program = new Program();
            program.ChooseExercise();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            
        }
        public void ChooseExercise()
        {
            Console.WriteLine("Choose the exercise to display (1, 2, 3, 4, 5):");

            int choice;

            choice = int.Parse(Console.ReadLine());

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
                    TemperatureConvertor temperatureConvertor = new TemperatureConvertor();
                    temperatureConvertor.Convertor();
                    break;
                case 4:
                    IdealMass idealMass = new IdealMass();
                    idealMass.Controller();
                    break;
                case 5:
                    Medii medii = new Medii();
                    medii.Controller();
                    break;
                default:
                    Console.WriteLine("Exercise does not exist");
                    break;
            }
        }
    }
}
