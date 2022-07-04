using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    internal class Program
    {
        /* Разработать структуру для решения линейного уравнения 0=kx+b. 
         * Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. 
         * Для решения уравнения предусмотреть метод Root. 
         * Создать экземпляр разработанной структуры. 
         * Осуществить использование экземпляра в программе.
         */

        static void Main(string[] args)
        {
            Console.Write("Введите коэффициенты линейного уравнения вида 0=kx+b. \nВведите k: ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Solution solution = new Solution(k, b);
            Console.WriteLine(solution.Root());
            Console.ReadKey();

        }
    }
}
