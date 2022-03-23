package Project;

import java.lang.Math;
import java.util.Random;
import java.util.Scanner;
import java.util.concurrent.ThreadLocalRandom;

public class Project {

	static int Min(int[] A, int max, int min)
    {
        for (int i = 0; i < 15; i++)
        {
            if (A[i] < min)
            {
                min = A[i];
            }
        }
        return min;
    }
    static int Max(int[] A, int max, int min)
    {
        for (int i = 0; i < 15; i++)
        {
            if (A[i] > max)
            {
                max = A[i];
            }
        }
        return max;
    }
    
    static int output(int[] A)
    {
   	System.out.print("Array: ");
        for (int i = 0; i < 15; i++)
        {
      	System.out.print(/*"[" + i + "] " +*/ A[i] + "   ");
       }
       return 1;
  }

	public static void main(String[] args) {

		Scanner scan = new Scanner(System.in);

        
        int Min_Rand = 0;
        int Max_Rand = 100;
        int[] A = new int[15];
        for (int i = 0; i < A.length; i++)
        {
            A[i] = ThreadLocalRandom.current().nextInt(Min_Rand, Max_Rand);
        }
      
        

        int max = A[0];
        int min = A[0];

        System.out.println("Min: " + Min(A, max, min));
        System.out.println("Max: " + Max(A, max, min));
        System.out.println("" + output(A));
	}
}