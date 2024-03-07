using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Fibonacci
    { 
        public void WriteFibonacci()
        {
            Console.WriteLine("Fibonacci Program");
            Console.WriteLine("Enter how many numbers of the Fibonacci sequence you want to see: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.Write(Fib(i) + " ");
            }
            Console.WriteLine();
        }

        private int Fib(int n)
        {
            if (n <= 1)
                return n;
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
