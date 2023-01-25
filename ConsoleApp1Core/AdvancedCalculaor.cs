using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Core
{
	class AdvancedCalculaor
	{
		public int GetFactorial(int value)
		{
			if (value < 1)
				return 1;
			else
				return value * GetFactorial(value - 1);
		}

		public int GetFactorial2(int value)
		{
			int result = 1; 
			for (int i = 1; i <= value; i++)
			{
				result *=  i;
			}
			return result;
		}
	}
}
