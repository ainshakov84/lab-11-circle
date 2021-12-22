using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Статические_методы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите координату x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите координату y");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение радиуса");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("площадь круга = " + Сircle.GetSquareСircle(r));
            Console.WriteLine("длина окружности = " + Сircle.GetLengthСircle(r));
            
            if (r > Сircle.GetPointСircle(x, y))
            {
                Console.WriteLine("точка принадлежит окружности");
            }
            else 
                    {
                Console.WriteLine("точка не принадлежит окружности");
            }

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
