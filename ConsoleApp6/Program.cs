using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10];
            RandomValue(mas);
            Console.WriteLine("Вывод изначального массива");
            Output(mas);
            Met(mas);
            Console.WriteLine("Вывод отсортированного массива");
            Output(mas);
            Console.ReadKey();  
        }

        static void RandomValue(int[] mas)
        {
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(-10, 11);
            }
        }
        static void Met(int[] mas)
        {
            //int temp;
            //for (int i = 0; i < mas.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < mas.Length; j++)
            //    {
            //        if (mas[i] > mas[j])
            //        {
            //            temp = mas[i];
            //            mas[i] = mas[j];
            //            mas[j] = temp;
            //        }
            //    }
            //}
            Array.Sort(mas);
            foreach (var element in mas) ;
        }
        static void Output(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
        }

    }
}
