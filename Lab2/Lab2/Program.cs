using System;

namespace Lab2
{
	class Program
	{
		static void Main(string[] args)
		{
			double x; // вхідний аргумент
			double a; // вхідний параметр
			double b; // вхідний параметр
			double c; // вхідний параметр
			double F = 0; // результат обчислення виразу

			Console.WriteLine("a = "); a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("b = "); b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("c = "); c = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("x = "); x = Convert.ToInt32(Console.ReadLine());

			// спосіб 1: розгалуження в скороченій формі
			if (x < 5 && c != 0)
				F = (-a) * x * x - b;

			if (a > 5 && c == 0)
				F = (x - a) / (x);

			if (!(a < 0 && b != 0) && !(a > 0 && b == 0))
				F = (-x)/c;

			Console.WriteLine($"1) F =  {Math.Round(F, 2)} ");

			// спосіб 2: розгалуження в повній формі
			if (x < 5 && c != 0)
				F = (-a) * x * x - b;

			else
				if (a > 5 && c == 0)
				F = (x - a) / (x);

			else
				F = (-x) / c;

			Console.WriteLine($"2) F = {F}");
		}
	}
}
