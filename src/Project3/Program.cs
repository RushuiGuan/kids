using System;

namespace Project3
{
    class Program
    {
        static void PrintPositiveIntegers(){
            Console.Write("Please enter a positive number: ");
            string line = Console.ReadLine();

            int n;
            if (int.TryParse(line, out n))
            {
                if (n <= 0)
                {
                    Console.WriteLine("This is not a positive number");
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(i);
                        Console.Write(",");
                    }
                }
            }
            else
            {
                Console.WriteLine("This is not a number");
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
