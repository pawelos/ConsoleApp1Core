using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1Core
{
	class Program
	{
		public static void CalculatorProc(int a, int b)
		{
			Console.WriteLine("-----  Calculator Proc ----- ");
			int wynik = a + b;
			Console.WriteLine("Dodawanie: {0} + {1} = {2}", a, b, wynik);
			wynik = a - b;
			Console.WriteLine("Odejmowanie: {0} - {1} = {2}", a, b, wynik);
			wynik = a * b;
			Console.WriteLine("Mnozenie: {0} * {1} = {2}", a, b, wynik);
			wynik = a / b;
			Console.WriteLine("Dzielenie: {0} / {1} = {2}", a, b, wynik);
		}

		public static int Silnia(int i)
		{
			if (i < 1)
				return 1;
			else
				return i * Silnia(i - 1);
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Podaj a:");
			int a = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Podaj b:");
			int b = Convert.ToInt32(Console.ReadLine());
			CalculatorProc(a, b); 
			AdvancedCalculaor ac = new AdvancedCalculaor();
			Console.WriteLine("Silnia = {0}", ac.GetFactorial(3));
		}

	}
}
