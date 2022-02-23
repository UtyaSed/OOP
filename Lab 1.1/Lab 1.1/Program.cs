using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
			// Завдання 1
			Console.WriteLine("Завдвння 1:");
			double x;
			double y;
			double A = 0;
			double B = 0;

			Console.WriteLine("x = "); x = Convert.ToInt32(Console.ReadLine());

			A = (x * x) * (Math.Sin(x / 2));

			// 1 
			if (x <= -5)
				B = Math.Atan(Math.Exp(x));
			if (-5 < x && x <= 0)
				B = 1 + (Math.Pow(x, 3) / 4);
			if (x > 0)
				B = Math.Log(Math.Abs(x)) - (x / 5);

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


			// Завдання 2
			Console.WriteLine("Завдвння 2:");
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
				F = (-x) / c;

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



			// Завдання 3
			Console.WriteLine("Завдвння 3:");

			int i = 1, N, k;

			double S;

			Console.WriteLine("N = "); N = Convert.ToInt32(Console.ReadLine());

			S = 0;
			k = i;
			while (k <= N)
			{
				S += (1.0 / ((2 * k + 1) * (2 * k + 1)));
				k++;
			}
			Console.WriteLine($"S = {Math.Round(S, 2)}");

			S = 0;
			k = i;
			do
			{
				S += (1.0 / ((2 * k + 1) * (2 * k + 1)));
				k++;
			} while (k <= N);
			Console.WriteLine($"S = {Math.Round(S, 2)}");

			S = 0;
			for (k = i; k <= N; k++)
			{
				S += (1.0 / ((2 * k + 1) * (2 * k + 1)));
			}
			Console.WriteLine($"S = {Math.Round(S, 2)}");

			S = 0;
			for (k = N; k >= i; k--)
			{
				S += (1.0 / ((2 * k + 1) * (2 * k + 1)));
			}
			Console.WriteLine($"S = {Math.Round(S, 2)}");


			// Завдання 4
			Console.WriteLine("Завдвння 4:");

			double xp, xk, dx;

			Console.WriteLine("xp = "); xp = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("xk = "); xk = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("dx = "); dx = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("a = "); a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("b = "); b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("c = "); c = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("---------------------------");
			Console.WriteLine("|".PadRight(5) + "x" + "|".PadLeft(5) + "F".PadLeft(5) + "|".PadLeft(5));
			Console.WriteLine("---------------------------");

			x = xp;
			while (x <= xk)
			{
				if (a < 5 && c != 0)
					F = (-a) * x * x - b;
				else
					if (a > 5 && c == 0)
					F = (x - a) / x;
				else
					F = (-x) / c;

				Console.WriteLine("|".PadRight(5) + x + "|".PadLeft(5) + "".PadLeft(5) + F + " |".PadLeft(5));
				x += dx;
			}
			Console.WriteLine("---------------------------");

		}
	}
}
