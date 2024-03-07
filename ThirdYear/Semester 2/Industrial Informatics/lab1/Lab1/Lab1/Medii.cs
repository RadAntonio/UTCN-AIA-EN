using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab1
{
    internal class Medii
    {   
        public void MedieGeometrica(int[] sir)
        {
            double sumaMediaGeometrica = 0;
            for (int i = 0; i < sir.Length; i++)
            {
                sumaMediaGeometrica = sumaMediaGeometrica + sir[i];
            }
            double mediaGeometrica = 0;
            mediaGeometrica = Math.Pow(sumaMediaGeometrica, 1/sir.Length);
            Console.WriteLine("\nGeometric Average is: " +  mediaGeometrica);
        }
        public void MedieAritmetica(int[] sir) 
        {
            double sumaMediaAritmetica = 0;
            for (int i = 0; i < sir.Length; i++)
            {
                sumaMediaAritmetica = sumaMediaAritmetica + sir[i];
            }
            double mediaAritmetica = 0;
            mediaAritmetica = sumaMediaAritmetica / sir.Length;
            Console.WriteLine("\nAritmetic Average is: " + mediaAritmetica);
        }
        public void Controller()
        {
            Console.WriteLine("Avreges Calculator: (1-Aritmetica / 2-Geometrica");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Length of the array: ");
            int length = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Input Numbers: ");
            string input = Console.ReadLine();

            // Split the input string by spaces to get individual numbers
            string[] numbersAsStrings = input.Split(' ');

            // Create an array to store the parsed numbers
            int[] numbers = new int[numbersAsStrings.Length];

            // Parse each string into an integer and store it in the numbers array
            for (int i = 0; i < numbersAsStrings.Length; i++)
            {
                numbers[i] = int.Parse(numbersAsStrings[i]);
            }

            // Print the vector
            Console.WriteLine("The vector you entered:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            switch (choice)
            {
                case 1:
                    MedieAritmetica(numbers);
                    break;
                case 2:
                    MedieGeometrica(numbers);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;  

            }
            Program program = new Program();
            program.ChooseExercise();
        }
    }
}
