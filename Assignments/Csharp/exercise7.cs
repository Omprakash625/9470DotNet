using System;

namespace Assignments
{

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the first number :");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the second number :");
			int num2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(num1 + " + " + num2 + " = " + (num1 +num2));
			Console.WriteLine(num1 + " - " + num2 + " = " + (num1 -num2));
			Console.WriteLine(num1 + " * " + num2 + " = " + (num1 *num2));
			Console.WriteLine(num1 + " / " + num2 + " = " + (num1 /num2));
			Console.WriteLine(num1 + " % " + num2 + " = " + (num1 %num2));
			Console.ReadKey();
		}
	}
}
