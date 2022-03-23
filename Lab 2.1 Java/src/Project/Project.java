package Project;

import java.lang.Math;
import java.util.Random;
import java.util.Scanner;
import java.util.concurrent.ThreadLocalRandom;

public class Project {

	 static int array_result(int[] A, int P)
	    {
	        for (int i = 0; i < 21; i++)
	        {
	        	  if (!(A[i] % 2 == 1 && A[i] % 3 == 0))
	            {
	                P += A[i];
	            }
	        }
	        return P;
	    }
	    static int output(int[] A, int P)
	    {
	    	System.out.println("Array: ");
	        for (int i = 0; i < 21; i++)
	        {
	        	System.out.print("[" + i + "] " + A[i] + "   ");
	        	if(i == 13) {
	        		System.out.println("");
	        	}
	        }
	        return 1;
	    }
		public static void main(String[] args) {

			Scanner scan = new Scanner(System.in);

	        
	        
	        int Min = 10;
	        int Max = 90;
	        int[] A = new int[21];
	        for (int i = 0; i < A.length; i++)
	        {
	            A[i] = ThreadLocalRandom.current().nextInt(Min, Max);
	        }
	        
	        
	        int P = 0;
	        System.out.println("Result: " + array_result(A, P));
	        System.out.println("Array: " + output(A, P));
		}
	}