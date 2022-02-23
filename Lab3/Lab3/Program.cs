using System;

namespace Lab3
{
	class Program
	{
		static void Main(string[] args)
		{
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

		}
	}
}