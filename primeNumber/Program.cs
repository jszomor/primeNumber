using System;
using System.Collections.Generic;

namespace primeNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a number:");
			string  input = Console.ReadLine();
			Int32.TryParse(input, out int number);
			List<int> primeNumbers = new List<int>();

			for (int i = 1; i <= number; i++)
			{
				if (isPrime(i))
				{
					primeNumbers.Add(i);
				}
			}
			foreach (var item in primeNumbers)
			{
				Console.WriteLine(item);
			}
			Console.ReadKey();
		}
		private static bool isPrime(int n)
		{
			for (int i = 2; i < n; i++)
			{
				if (n % i == 0)
					return false;
			}
			return true;
		}
	}
}
