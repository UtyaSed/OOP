using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._2
{
    class Program
    {
        static int Min(int[] a, int max, int min)
        {
            for (int i = 0; i < 15; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }
        static int Max(int[] a, int max, int min)
        {
            for (int i = 0; i < 15; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;


        }
       /* static int Output(int[] a)
        {
            Console.Write("Masyv: ");
            for (int i = 0; i < 15; i++)
            {
                Console.Write(   "[" + i + "] " +   a[i] + "   ");
            }
            return 1;
        }
       */

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int max = a[0];
            int min = a[0];
            Console.WriteLine("Min: " + Min(a, max, min));
            Console.WriteLine("Max: " + Max(a, max, min));
       //   Console.WriteLine(Output(a));
            Console.ReadKey();
        }
    }
}