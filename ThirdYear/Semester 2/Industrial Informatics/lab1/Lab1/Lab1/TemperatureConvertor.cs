using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class TemperatureConvertor
    {
        public void C2F(double temp)
        {
            double rez = temp * 9 / 5 + 32;
            Console.WriteLine(rez + "F");
        }
        public void F2C(double temp)
        {
            double rez = (temp - 32) * 5 / 9;
            Console.WriteLine(rez + "C");
        }
        public void Convertor()
        {
            TemperatureConvertor temperatureConvertor = new TemperatureConvertor();
            Console.WriteLine("press 1 to C2F \npress 2 to F2C");
            int type;
            type = int.Parse(Console.ReadLine());

            Console.WriteLine("Degrees:");
            double temp = double.Parse(Console.ReadLine());
            switch (type)
            {
                case 1:
                    temperatureConvertor.C2F(temp);
                    break;

                case 2:
                    temperatureConvertor.F2C(temp);
                    break; 

                default:
                    Console.WriteLine("not a case");
                    break;

            }
            Program program = new Program();
            program.ChooseExercise();
        }
    }
        
}
