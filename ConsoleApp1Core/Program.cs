using System;

namespace ConsoleApp1Core
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("kalkulator");

			var input = Console.ReadLine();
			int a = Int32.Parse(input);
			input = Console.ReadLine();
			int b = Int32.Parse(input);
			int wynik;

			wynik = a + b;
			Console.WriteLine("Dodawanie: {0} + {1} = {2}",a,b,wynik);

			wynik = a - b;
			Console.WriteLine("Odejmowanie: {0} - {1} = {2}", a, b, wynik);

			wynik = a * b;
			Console.WriteLine("Mnozenie: {0} * {1} = {2}", a, b, wynik);


			wynik = a / b;
			Console.WriteLine("Dzielenie: {0} / {1} = {2}", a, b, wynik);
			

			// obiektowo
			// Base Calculator - metody

		}
	}
}
