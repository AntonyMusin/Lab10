using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle();
            angle.Gradus = 359;//Присваиваем значение аргументов создаваемого объекта класса поочередно обращаясь к ним.
            angle.Min = 60;
            angle.Sec = 60;
            Console.WriteLine();
            Console.WriteLine("Величина угла в радианах:");
            angle.ToRadians();
            Console.ReadKey();
        }
    }
    class Angle
    {
        int gradus;
        public int Gradus// Проверка на отрицательное значение и корректность диапазона ввода.
        {
            set
            {
                if (value < 0 || value>359)
                {
                    Console.WriteLine("Введите положительное число, от 0 до 359!");
                }
                else
                {
                    gradus = value;
                }
            }
            get
            {
                return gradus;
            }
        }

        int min;
        public int Min
        {
            set
            {
                if (value < 0 || value > 61)
                {
                    Console.WriteLine("Введите положительное число, от 0 до 60!");
                }
                else
                {
                    min = value;
                }
            }
            get
            {
                return min;
            }
        }

        int sec;
        public int Sec
        {
            set
            {
                if (value < 0 || value > 61)
                {
                    Console.WriteLine("Введите положительное число, от 0 до 60!");
                }
                else
                {
                    sec = value;
                }
            }
            get
            {
                return sec;
            }
        }

        public void ToRadians()
        {
            Console.WriteLine((gradus + min / 60 + sec / 3600) * Math.PI / 180);
        }
    }
}
            