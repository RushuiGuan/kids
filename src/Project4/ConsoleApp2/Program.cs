using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class TuanProject4
{
	public static int Sum(int num1, int num2)
	{
		int total;
		total = num1 + num2;
		return total;
	}

	public static void Main()
	{

		bool condition = true;

		while (condition) {
	        Console.Write ("\n\nFunction to calculate the sum of two numbers :\n");
			Console.Write("--------------------------------------------------\n");
			Console.Write("Enter a number:: ");

			string txt;
			txt = Console.ReadLine();
			int n1;
			n1 = Convert.ToInt32(txt);
			Console.Write("Enter another number: ");

			
			txt = Console.ReadLine();
			int n2 = Convert.ToInt32(txt);

			int Tuan;
			Tuan = n1 * n2;
			Console.WriteLine("\nThe product of the two numbers is : {0} \n", Tuan);
			Console.WriteLine(" Do you want to do it one more time ?");

			txt = Console.ReadLine();
			/*
			if someone type in yes, keep going
			if someone type in no, stop the program
			if someone type in something else, keep going as well;

			if(true){
				//do something
			
			}
			*/
			if (txt == "no") { 
				condition = false;
			}
		};
	}
}