using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 12, 8, 20, 3, 15, 7 };
            int max= 0, min= 0;
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] > mas[max])
                    max = i;
                if (mas[i] < mas[min])
                    min= i;
            }

            Console.WriteLine($"Максимальный элемент: {mas[max]} (Индекс: {max})");
            Console.WriteLine($"Минимальный элемент: {mas[min]} (Индекс: {min})");
            (mas[max], mas[min]) = (mas[min], mas[max]);
            Console.WriteLine("\nМассив после замены максимального и минимального элементов:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
            int schet = Math.Abs(max - min) - 1;
            Console.WriteLine($"\nКоличество элементов между максимальным и минимальным: {schet}");
            Console.ReadKey();
        }
    }
}
