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
		total = (num1 * num2) / 2 ; 
		return total;
	}

	public static void Main()
	{


		{
			Console.Write("\n\nThis program will calculate the area of the triangle :\n");
			Console.Write("__________________________________________________________\n");

			Console.Write("Please enter the height of the triangle (in^2): ");

			string Firstnumber;
			Firstnumber = Console.ReadLine();
			int n1;
			n1 = Convert.ToInt32(Firstnumber);

			Console.Write("\n\nPlease enter the base of the triangle (in^2): ");

			string Secondnumber;
			Secondnumber = Console.ReadLine();
			int n2;
			n2 = Convert.ToInt32(Secondnumber);

			




			




			int Tuan;
			Tuan = (n1 * n2) / 2 ;
			Console.WriteLine("\nThe area is : {0} in^2\n", Tuan);
			Firstnumber = Console.ReadLine();

		}


	}
}

