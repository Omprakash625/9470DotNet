using System;

namespace Assignments
{

	class Program
	{
		static void Main(string[] args)
		{	
			int num1,num2,num3,num4;
			Console.WriteLine("Enter the first number:");
			num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the second number:");
			num2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the third number:");
			num3 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the fourth number:");
			num4 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("The average of entered number are {0} ", ((num1+num2+num3+num4)/4));
			Console.ReadKey();

		}
	}
}
