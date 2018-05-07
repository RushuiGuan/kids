using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuanProject2
{
	class Program
	{
		static int Main(string[] args)
		{
			int a = 1;
			int b = 2;

			int c = Sum(a, b);
			Console.WriteLine(c);


			a = 100;
			b = 200;
			c = Sum(a, b);
			c += 2;
			Console.WriteLine(c);

			return c;
		}
	       static int Sum(int y, int x) {
			int z;
			z = x + y;
			return z;

		}

	}
}
