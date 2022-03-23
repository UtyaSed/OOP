using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            const int n = 21;
            int[] a = new int[n];

            int low = 10;
            int high = 90;

            for (int i = 0; i < n; i++)
                a[i] = low + rnd.Next() % (high - low + 1);

            Console.Write("a[] = ");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} , ");

            }
            Console.WriteLine("}");
            Console.WriteLine();

            int S = 0;
            int k = 0;

            for (int i = 0; i < n; i++)
                if (!(a[i] % 2 == 1 && a[i] % 3 == 0))
                {
                    S += a[i];
                    k++;
                    a[i] = 0;
                }

            Console.WriteLine($"Number = {k}");
            Console.WriteLine($"Sum = {S}");
            Console.WriteLine();
            Console.Write("a[] = {");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} , ");
            }
            Console.WriteLine("}");
            Console.WriteLine();
        }
    }
}