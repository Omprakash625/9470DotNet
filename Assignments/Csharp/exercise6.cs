using System;

namespace Assignments
{

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the first number to multiply :");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the second number to multiply :");
			int num2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the third number to multiply :");
			int num3 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(num1 + " * " + num2 + " * " + num3 + " = " + (num1 * num2 * num3));
			Console.ReadKey();
		}
	}
}
