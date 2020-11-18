using System;

public class Average{
	
	public static void Main(){
		
		double totalMarks = 0, countMarks = 0, mark , average;
		string markInput;
		
		
		Console.Write("Insert a mark: ");
		markInput = Console.ReadLine();		 

		while (markInput != "end") 
		{
			mark = Convert.ToDouble(markInput);
			
			countMarks++;  
			totalMarks += mark;  
		
			Console.Write("Insert a mark: ");
			markInput = Console.ReadLine();
		}
		
		if (countMarks != 0) 
		{	
			average = totalMarks / countMarks;  
			Console.WriteLine("The average is {0}.", average);
		}
	}
}
