using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Core
{
	class BaseCalculator
	{
		int Add(int value1, int value2)
		{
			return value1 + value2;
		}

		int Substruct(int value1, int value2)
		{
			return value1 - value2;
		}

		int Multiply(int value1, int value2)
		{
			return value1 * value2;
		}

		int Devide(int value1, int value2)
		{
			return value1 / value2;
		}
	}
}
