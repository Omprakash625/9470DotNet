using System;

namespace Assignments
{

	class Program
	{
		static void Main(string[] args)
		{
			int number1, number2, number3;
 
			Console.Write("Enter first number (x): ");
			number1 = Convert.ToInt32(Console.ReadLine());
			     
			Console.Write("Enter second number (y) : ");
			number2 = Convert.ToInt32(Console.ReadLine());
			 
			Console.Write("Enter third number (z) : ");
			number3 = Convert.ToInt32(Console.ReadLine());
			 
			Console.Write("Result of (x+y)·z is {3} and x·y + y·z is {4} \n",number1, number2, number3, ((number1+number2)*number3), (number1*number2+number2*number3));
		}
	}
}
