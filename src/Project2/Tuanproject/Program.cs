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
			int a = 100;
			int b = 80;

			int c = Tuan(a, b);
			Console.WriteLine(c);


			a = 100;
			b = 200;
			c = Tuan(a, b);
			c += 2;
			Console.WriteLine(c);

			return c;
		}
		static int Tuan(int x, int y)
		{
			int z;
			z = x - y;
			return z;

		}

	}
}