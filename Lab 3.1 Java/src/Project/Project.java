package Project;

import java.lang.Math;
import java.util.Random;
import java.util.Scanner;
import java.util.concurrent.ThreadLocalRandom;
import javax.swing.Spring;

public class Project
{
	static int Countw(String str)
    {
		char[] tempString = new char[str.length()];
    	for (int i = 0; i < str.length(); i++) 
    	{
    		tempString[i] = str.charAt(i);
        }
        if (str.length() < 1)
        {
            return 0;
        }
        int w = 0;
        for (int i = 0; i < tempString.length; i++)
        {
            if (tempString[i] == 'w')
            {
                w++;
            }
        }
        return w;
    }
    static int Counth(String str)
    {
    	char[] tempString = new char[str.length()];
    	for (int i = 0; i < str.length(); i++) 
    	{
    		tempString[i] = str.charAt(i);
        }
        if (str.length() < 1)
        {
            return 0;
        }
        int h = 0;
        for (int i = 0; i < tempString.length; i++)
        {
            if (tempString[i] == 'h')
            {
                h++;
            }
        }
        return h;
    }
    static int Counti(String str)
    {
    	char[] tempString = new char[str.length()];
    	for (int i = 0; i < str.length(); i++) 
    	{
    		tempString[i] = str.charAt(i);
        }
        if (str.length() < 1)
        {
            return 0;
        }
        int ai = 0;
        for (int i = 0; i < tempString.length; i++)
        {
            if (tempString[i] == 'i')
            {
                ai++;
            }
        }
        return ai;
    }
    static int Countl(String str)
    {
    	char[] tempString = new char[str.length()];
    	for (int i = 0; i < str.length(); i++) 
    	{
    		tempString[i] = str.charAt(i);
        }
        if (str.length() < 1)
        {
            return 0;
        }
        int l = 0;
        for (int i = 0; i < tempString.length; i++)
        {
            if (tempString[i] == 'l')
            {
                l++;
            }
        }
        return l;
    }
    static int Counte(String str)
    {
    	char[] tempString = new char[str.length()];
    	for (int i = 0; i < str.length(); i++) 
    	{
    		tempString[i] = str.charAt(i);
        }
        if (str.length() < 1)
        {
            return 0;
        }
        int e = 0;
        for (int i = 0; i < tempString.length; i++)
        {
            if (tempString[i] == 'e')
            {
                e++;
            }
        }
        return e;
    }
    static String Change(String str)
    {
        String stringer;
        String string = str;
        if (str.length() < 1)
        {
            return str;
        } else
        {
            stringer = (str.replaceAll("while", "***"));
        }
        return stringer;
    }

    
    
    
    
    
	public static void main(String[] args) {

		Scanner scan = new Scanner(System.in);
	    String str;
	    System.out.print("Enter string: ");
	    str = scan.nextLine();
	    String dest;
	    dest = Change(str);
	    System.out.println("Modified string (param) : " + str);
	    System.out.println("Modified string (result): " + dest);
	    
	    
	}
}