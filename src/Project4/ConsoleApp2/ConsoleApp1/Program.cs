using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TuanProject4
{
	public static void GetTriangleArea() {

		Console.Write("Please enter the height of the triangle (in^2): ");

		string firstNumber;
		firstNumber = Console.ReadLine();
		double n1;
		n1 = Convert.ToDouble(firstNumber);

		Console.Write("\n\nPlease enter the base of the triangle (in^2): ");

		string secondNumber;
		secondNumber = Console.ReadLine();
		double n2;
		n2 = Convert.ToDouble(secondNumber);


		double Area;
		Area = n1 * n2 / 2;
		Console.WriteLine("\nThe area of the triangle is : {0} in^2\n", Area);

	}

	public static void GetCircleArea() { 
	}

	public static void GetSquareArea() { 
	}

	public static void GetRectangleArea() { 
	}

	public static void Main()
	{
		GetTriangleArea();
		GetSquareArea();
	}
}

