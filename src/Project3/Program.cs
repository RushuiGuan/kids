using System;

namespace Project3
{
	class Program
	{
		static bool PrintPositiveIntegers()
		{
			Console.Write("Please enter a positive integer: ");
			string line = Console.ReadLine();
			if (line == "stop") {
				return false;
			}
			int n;
			if (int.TryParse(line, out n))
			{
				if (n <= 0)
				{
					Console.WriteLine("This is not a positive integer");
				}
				else
				{
				 for (int i = 0; i <= n; i=i+1)
					{
						Console.Write(i);
						Console.Write(",");
					}
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("This is not an integer");
			}
			return true;
		}


		static string GetName()
		{
			return "Tuan";
		}

		static int GetRetangleArea(int length, int width)
		{
			int area = length * width;
			return area;
		}

		static double GetTriangleArea(int length, int height)
		{
			int area = length * height / 2;
			return area;
		}
		static void Run()
		{
		}
		static void Main(string[] args)
		{
			
			while (PrintPositiveIntegers())
			{ 
				
			}
		}
	}
}
