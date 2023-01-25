using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1Core
{
	class Program
	{
		

		static void Main(string[] args)
		{
			Console.WriteLine("Podaj a:");
			int a = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Podaj b:");
			int b = Convert.ToInt32(Console.ReadLine());
			AdvancedCalculaor ac = new AdvancedCalculaor();
			Console.WriteLine("Silnia = {0}", ac.GetFactorial(3));
		}

	}
}
