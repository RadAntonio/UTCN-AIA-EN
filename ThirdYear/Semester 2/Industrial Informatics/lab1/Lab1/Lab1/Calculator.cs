using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Calculator
    {
        public void Aduna(double a, double b)
        {
            double rezultat;
            rezultat =  a + b;
            Console.WriteLine("Result for addition is: " + rezultat);
        }

        public void Scade(double a, double b)
        {
            double rezultat;
            rezultat = a - b;
            Console.WriteLine("Result for subtraction is: " + rezultat);
        }

        public void Inmulteste(double a, double b)
        {
            double rezultat;
            rezultat = a * b;
            Console.WriteLine("Result for multiplication is: " + rezultat);
        }

        public void Imparte(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Cant devide by 0.");
            }
            double rezultat;
            rezultat = a / b;
            Console.WriteLine("Result for division is: " + rezultat);
        }
        public void Calcule()
        {
            Console.WriteLine("num1:");
            double numar1 = double.Parse(Console.ReadLine());
            Console.WriteLine("num2:");
            double numar2 = double.Parse(Console.ReadLine());

            Calculator calculator = new Calculator();

            calculator.Aduna(numar1, numar2);
            calculator.Scade(numar1, numar2);
            calculator.Inmulteste(numar1, numar2);
            calculator.Imparte(numar1, numar2);
        }
    }
}
