package Project;

import java.lang.Math;
import java.util.Scanner;

public class Project {

	public static void main(String[] args) {
		

			Scanner scan = new Scanner(System.in);

			int i = 1, N, k;
			double S;
			System.out.print("N = "); 
			N = scan.nextInt();
			S = 0;
			k = i;
			while (k <= N)
	        {
				S += (1.0 / ((2 * k + 1) * (2 * k + 1)));
	            k++;
	        }
	        System.out.println("" + String.format("%.2f", S));
	        S = 0;
			k = i;
	        do
	        {
	        	S += (1.0 / ((2 * k + 1) * (2 * k + 1)));
	            k++;
	        } while (k <= N);
	        System.out.println("" + String.format("%.2f", S));
	        S = 0;
	        for (k = N; k <= i; k++)
	{
	        	S += (1.0 / ((2 * k + 1) * (2 * k + 1)));
	        }
	        System.out.println("" + String.format("%.2f", S));
	        S = 0;
	        for (k = N; k >= i; k--)

	{
	        	 S += 1 / (Math.pow(( 2 * k + 1 ), 2)) ;
	        }
	        System.out.println("" + String.format("%.2f", S));
		}

	}