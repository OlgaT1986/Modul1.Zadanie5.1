using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sum = 0, resul = 0;
            double[] mas = new double[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + " элемент массива");
                mas[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < 7; i++)
            {
                Sum = Sum + mas[i];
            }
            resul = Sum / 7;
            Console.WriteLine("Среднее арифметическое значение = " + resul);
            Console.ReadKey();
        }
    }
}
