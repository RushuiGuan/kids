using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class TuanProject4
{
	public static int Sum(int num1, int num2 ,int num3)
	{
		int total;
		total = num1 + num2 + num3;
		return total;
	}

	public static void Main()
	{

		
		{
			Console.Write("\n\nThis program will calculate the sum any three numbers :\n");
			Console.Write("___________________________________________________________\n");
			
			Console.Write("Please enter first number:: ");

			string Firstnumber;
			Firstnumber = Console.ReadLine();
			int n1;
			n1 = Convert.ToInt32(Firstnumber);

			Console.Write("\n\n Please enter sencond number:\n ");
						
		    string Secondnumber;
			Secondnumber = Console.ReadLine();
			int n2;
			n2 = Convert.ToInt32(Secondnumber);
			
			Console.Write("\n\n Please enter a 3rd number:\n ");




			string Thirdnumber;
			Thirdnumber = Console.ReadLine();
			int n3 = Convert.ToInt32(Thirdnumber);

			
			
			
			int Tuan;
			Tuan = n1 + n2 + n3;
			Console.WriteLine("\nThe answer is : {0} \n", Tuan);
			Firstnumber = Console.ReadLine();
			
			}
			
			
		}
	}
