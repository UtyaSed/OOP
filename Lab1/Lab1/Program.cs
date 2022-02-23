using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
	class Program
	{
		static void Main(string[] args)
		{
			double x;
			double y; 
			double A = 0; 
			double B = 0; 

			Console.WriteLine("x = "); x = Convert.ToInt32(Console.ReadLine());

			A = (x * x) * (Math.Sin(x/2));

			// 1 
			if (x <= -5)
				B = Math.Atan(Math.Exp(x));
			if (-5 < x && x <= 0)
				B = 1 + (Math.Pow(x, 3)/4);
			if (x > 0)
				B = Math.Log(Math.Abs(x))-(x/5) ;

			y = A + B;

			Console.WriteLine("\n");
			Console.WriteLine($"1) y = {Math.Round(y, 2)} \n");

			// 2
			if (x <= -5)
				B = Math.Atan(Math.Exp(x));
			else
				if (x > 0)
				B = Math.Log(Math.Abs(x)) - (x / 5);
			else
				B = 1 + (Math.Pow(x, 3) / 4);

			y = A + B;

			Console.WriteLine($"2) y = {y} \n");
		}
	}
}