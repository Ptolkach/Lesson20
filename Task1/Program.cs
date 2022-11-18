using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите r:");
            double r = Convert.ToDouble(Console.ReadLine());

            MyDelegate md = Length;
            Console.WriteLine("Длина окружности: {0:f2}", md(r));

            md = Square;
            Console.WriteLine("Площадь круга: {0:f2}", md(r));

            md = Volume;
            Console.WriteLine("Объем шара: {0:f2}", md(r));

            Console.ReadKey();


        }
        static double Length(double r) => Math.PI * 2 * r;
        static double Square(double r) => Math.PI * r * r;
        static double Volume(double r) => (Math.PI * r * r * 3 * 4) / 3;

    }
}
