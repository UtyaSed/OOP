package Project;
import java.util.Scanner;

public class Student 
{
	private String name;
	private int no;
	   private double physics;
       private double programming;
       private double history;
	
	
	public String getName() { return name; }
	public int getNo() { return no; }
	
	 public double getPhysics() { return physics; }
     public double getProgramming() { return programming; }
     public double getHistory() { return history; }
     public double GetAverage() { return ((history + physics + programming) / 3); }
	public void setName(String nm) { this.name = nm; }
	
	public boolean setNo(int num)
	{
	if (num > 0)
	{
	no = num;
	return true;
	}
	else
	{
	no = 0;
	return false;
	}
	}
	
	public boolean setPhysics(double p)
    {
        if (p > 0 && p < 6)
        {
            physics = p;
            return true;
        }
        else
        {
            physics = 0;
            System.out.println("You have entered an incorrect estimate, please try again!");
            System.out.println("=========================================================");
            return false;
        }
    }
	
	public boolean setProgramming(double pr)
    {
        if (pr > 0 && pr < 6)
        {
            programming = pr;
            return true;
        }
        else
        {
            programming = 0;
            System.out.println("You have entered an incorrect estimate, please try again!");
            System.out.println("=========================================================");
            return false;
        }
    }

    public boolean setHistory(double h)
    {
        if (h > 0 && h < 6)
        {
            history = h;
            return true;
        }
        else
        {
            history = 0;
            System.out.println("You have entered an incorrect estimate, please try again!");
            System.out.println("=========================================================");
            return false;
           
        }
    }
    
	public boolean Init(String nm, int num, double p, double pr, double h)
	{
		  setName(nm);
          return setNo(num) && setPhysics(p) && setProgramming(pr) && setHistory(h);
    }
	
	public void Read()
	{
	Scanner scan = new Scanner(System.in); 
	
	String nm;
    int num;
    double p;
    double pr;
    double h;
	System.out.println("Name: ");
	nm = scan.nextLine();
	do
	{
	System.out.println("Number: ");
	num = scan.nextInt();
	System.out.println("Physics: ");
	p = scan.nextDouble();
	System.out.println("Programming: ");
	pr = scan.nextDouble();
	System.out.println("History: ");
	h = scan.nextDouble();
	} while (!Init(nm, num, p, pr, h));
	}
	
	public void Display()
	{
	System.out.println("===========================");
	System.out.println("Name: " + name);
	System.out.println("Number: " + no);
	System.out.println("Physics: " + physics);
	System.out.println("Programming: " + programming);
	System.out.println("History: " + history);
	System.out.println("===========================");
	}
	}
