using System;

namespace Assignments
{

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the numbers :");
			int num1 = Convert.ToInt32(Console.ReadLine());
			int num2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Result of addition = " + (num1 + num2));
			Console.ReadKey();
		}
	}
}
