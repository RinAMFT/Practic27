using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = new int[5];
            Input(omas);
            For(omas);
            Console.ReadKey();
        }

        static void Input(int[] omas)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"omas[{i}]: ");
                omas[i] = int.Parse(Console.ReadLine());
            }
        }
        static void For(int[] omas)
        {
            Array.Reverse(omas);
            foreach (var element in omas)
                Console.Write($"{element} ");
            //for (int i = omas.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(omas[i]);
            //}
        }
    }
}
