using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student g = new Student();
            g.Read();
            g.Display();
            Console.WriteLine($"Average score:   {Math.Round(g.GetAverage(), 1)}");
        }

    }
}