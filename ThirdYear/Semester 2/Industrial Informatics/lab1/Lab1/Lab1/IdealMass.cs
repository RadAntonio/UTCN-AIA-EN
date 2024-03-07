using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class IdealMass
    {
        public void Barbati(double inaltime, double varsta)
        {
            double idealMass = (inaltime - 100 - ((inaltime - 150) / 4)) + ((varsta - 20) / 4);
            Console.WriteLine("Ideal mass for a man with height " + inaltime + " and " + varsta + "years old is " + idealMass);
        }
        public void Femei(double inaltime, double varsta)
        {
            double idealMass = (inaltime - 100 - ((inaltime - 150) / 4)) + ((varsta - 20) / 4);
            Console.WriteLine("Ideal mass for a man with height " + inaltime + " and " + varsta + " years old is " + idealMass + "kg");
        }
        public void Controller()
        {
            Console.WriteLine("You identify as a: (m/f)");
            char sex = char.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your height: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter yout age: ");
            double age = double.Parse(Console.ReadLine());
            
            IdealMass idealmass = new IdealMass();

            switch (sex)
            {
                case 'm':
                    idealmass.Barbati(height, age);
                    break;
                case 'f':
                    idealmass.Femei(height, age);
                    break;
            }

            Program program = new Program();
            program.ChooseExercise();
        }
    }
}
