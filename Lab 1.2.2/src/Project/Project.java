package Project;

import java.lang.Math;
import java.util.Scanner;

public class Project {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);

        double x = 0; 
        double a = 0;
        double b = 0;
        double c = 0;
        double F = 0;
        System.out.print("a = ");
        a = scan.nextDouble();
        System.out.print("b = ");
        b = scan.nextDouble();
        System.out.print("c = ");
        c = scan.nextDouble();
        System.out.print("x = ");
        x = scan.nextDouble();
        
        if (x < 5 && c != 0) {
            F = (-a) * (x * x) - b ;
        }
        if (x > 5 && c == 0) {
            F = (x - a) / x ;
        }
        if (!(x < 5 && c != 0) && !(x > 5 && c == 0)) {
            F = (-x) / c;
        }
        System.out.println("");
        System.out.println("1) F = " + String.format("%.2f", F));
       
        if (x < 5 && c != 0)
        {
        	 F = (-a) * (x * x) - b ;
        }
        else
        {
            if (x > 5 && b + c == 0)
            {
            	 F = (x - a) / x ;
            }
            else
            {
            	F = (-x) / c;
            }
        }
        System.out.println("");
        System.out.println("2) F = " + String.format("%.2f", F));
	}

}