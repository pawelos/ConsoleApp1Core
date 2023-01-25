using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1Core
{
	class Program
	{
		public static void CalculatorObj(int a, int b)
		{
			Console.WriteLine(" ----- Calculator Obj ----- ");
			BaseCalculator bc = new BaseCalculator();
			Console.WriteLine("Dodawanie: " + bc.Add(a,b));
			Console.WriteLine("Dodawanie: {0} + {1} = {2}", a, b, bc.Add(a, b));
			Console.WriteLine("Odejmowanie: {0} - {1} = {2}",a,b,bc.Substruct(a,b));
			Console.WriteLine("Mnozenie: {0} * {1} = {2}",a,b,bc.Multiply(a,b));
			Console.WriteLine("Dzielenie: {0} / {1} = {2}",a,b,bc.Devide(a,b));
		}

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

		public static void Func1(int a, int b)
		{
		}


		public static int Silnia(int i)
		{
			if (i < 1)
				return 1;
			else
				return i * Silnia(i - 1);
		}

		public static void IsFirstInrange()
		{
			var p = new List<Int32> { };
			var LiczbaPierwsza = new Func<Int32, Boolean>(n =>
				{
					foreach (var x in p)
					{
						if (x * x > n)
						{
							return true;
						}
						if (n % x == 0)
						{
							return false;
						}
					}
					return true;
				}
			);
			foreach (var n in Enumerable.Range(2, 99))
			{
				if (LiczbaPierwsza(n))
				{
					// p.All(x => x * x > n || n % x != 0)
					p.Add(n);
				}
			}
			foreach (var x in p)
			{
				Console.WriteLine(x);
			}

		}

		static void Main(string[] args)
		{
			//Console.WriteLine("Podaj a:");
			//int a = Int32.Parse(Console.ReadLine());
			//Console.WriteLine("Podaj b:");
			//int b = Convert.ToInt32(Console.ReadLine());
			//CalculatorProc(a, b);
			//CalculatorObj(a, b);
			// IsFirstInrange();

			AdvancedCalculaor  ac = new AdvancedCalculaor();
			Console.WriteLine("Silnia = {0}", ac.GetFactorial(3));
			Console.WriteLine("Silnia = {0}", ac.GetFactorial2(3));
		}

	}
}
