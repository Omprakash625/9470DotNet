using System;

namespace Assignments
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a Number :");
			int num = Convert.ToInt32(Console.ReadLine());

			if(num % 2 == 0){
			Console.WriteLine("The number is Even .");
			Console.ReadKey();
			}
			else {
			Console.WriteLine("The number is Odd.");
			Console.ReadKey();	
			}
		}
	}
}