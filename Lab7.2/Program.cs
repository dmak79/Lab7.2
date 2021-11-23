using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну ребра куба:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Обьем куба:");
            CalcV(a);
            Console.WriteLine("Площадь поверхности куба:");
            CalcS(a);
            Console.ReadKey();
        }
        static void CalcV(int a)//метод вычисления объема куба
        {
            int V = a * a * a;
            Console.WriteLine(V);
        }
        static void CalcS(int a)//метод вычисления площади поверхности куба
        {
            int S = a * a * 6;
            Console.WriteLine(S);
        }
    }
}

