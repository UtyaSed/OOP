package Project;

public class Main 
{
public static void main(String[] args) 
	{
		Student g = new Student();
		
		g.Read();
		g.Display();
		System.out.println("Average score: " + (String.format("%.2f", g.GetAverage()) ));

	}
}
