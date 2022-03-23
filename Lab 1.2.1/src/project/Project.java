package project;

import java.lang.Math;
import java.util.Scanner;

public class Project {

	public static void main(String[] args) {

		Scanner scan = new Scanner(System.in);

        double x = 0;
        double y = 0; 
        double A = 0;
        double B = 0; 
        System.out.print("x = ");
		x = scan.nextDouble();
        A = (x * x) * Math.sin(x/2);
        
        if (x <= -5){
            B = Math.atan(Math.exp(x));
        }
        if (-5 < x && x <= 0) {
            B = 1 + ((Math.pow(x, 3))/4);
        }
        if (x > 0) {
            B = Math.log(x) - (x/5);
        }
        y = A + B;
        System.out.println("");
        System.out.println("1) y = " + String.format("%.2f", y));
    
        if (x <= -5) {
            B = Math.atan(Math.exp(x));
        }
        else if (x > 0) {
        	B = Math.log(x) - (x/5);
        }
        else {
        	B = 1 + ((Math.pow(x, 3))/4);
        }
        y = A - B;
        System.out.println("2) y = " + String.format("%.2f", y));
	}

}
