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
		total = 3 * num1 * 2;
		return total;
	}

	public static void Main()
	{

		
		{
			Console.Write("\n\n This is a program to calculate the area of the circle :\n");
			Console.Write("_______________________________________________________________\n");
			Console.Write("Please enter the radius (in):");

			string txt;
			txt = Console.ReadLine();
			int n1;
			n1 = Convert.ToInt32(txt);
			//Console.Write("Please enter the radius : ");


			//txt = Console.ReadLine();
			//int n2 = Convert.ToInt32(txt);

			int Tuan;
			Tuan = 3 * n1 * n1;
			Console.WriteLine("\nThe area of the circle is: {0} in^2 \n", Tuan);
			
			{
				
			}
		};
	}
}