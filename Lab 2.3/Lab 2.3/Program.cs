using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._3
{
    class Program
    {

        static void Create(int[,] a, int rowCount, int colCount, int Low, int High)
        {
            Random random = new Random();
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    a[i, j] = random.Next(Low, High);
                 }
            }
        }
        static void Print(int[,] a, int rowCount, int colCount)
        {
            Console.WriteLine("");
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    Console.Write(a[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
        static void Sort(int[,] a, int rowCount, int colCount)
        {
            for (int i0 = 1; i0 < rowCount + 1; i0++)
            {
                for (int i1 = 0; i1 < rowCount - i0 - 1; i1++)
                {
                    if ((a[i1, 0] > a[i1 + 1, 0]) 
                        ||
                        (a[i1, 0] == a[i1 + 1, 0] && 
                         a[i1, 1] < a[i1 + 1, 1]) 
                        || 
                        (a[i1, 0] == a[i1 + 1, 0] &&
                         a[i1, 1] == a[i1 + 1, 1] &&
                         a[i1, 3] < a[i1 + 1, 3]))
                    {
                        Change(a, i1, i1 + 1, colCount);
                    }
                }
            }
        }
        static void Change(int[,] a, int row1, int row2, int colCount)
        {
            int tmp;
            for (int j = 0; j < colCount; j++)
            {
                tmp = a[row1, j];
                a[row1, j] = a[row2, j];
                a[row2, j] = tmp;
            }
        }
        static void Calc(int[,] a, int rowCount, int colCount, int S, int k)
        {
            S = 0;
            k = 0;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (a[i, j] % 2 == 1 && !(a[i, j] % 3 == 0))
                    {
                        S += a[i, j];
                        k++;
                        a[i, j] = 0;
                    }
                }
            }
            Console.WriteLine("S = " + S);
            Console.WriteLine("k = " + k);
        }
        static void Main(string[] args)
        {
            int Low = 4;
            int High = 51;
            int rowCount = 8;
            int colCount = 5;
            int[,] a = new int[rowCount, colCount];
            Create(a, rowCount, colCount, Low, High);
            Print(a, rowCount, colCount);
            Sort(a, rowCount, colCount);
            Print(a, rowCount, colCount);
            int S = 0;
            int k = 0;
            Calc(a, rowCount, colCount, S, k);
            Print(a, rowCount, colCount);
            Console.ReadKey();
        }
    }
}