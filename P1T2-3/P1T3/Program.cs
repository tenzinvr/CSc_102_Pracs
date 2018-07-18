using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1T3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter the frequency of the drips (in seconds):");
			int intFreq = Convert.ToInt32(Console.ReadLine());

			double dblHr = 3600 / intFreq * 0.00025;
			double dblDay = 86400 / intFreq * 0.00025;
			double dblWk = 604800 / intFreq * 0.00025;

			Console.WriteLine("You are wasting;");
			Console.WriteLine(Convert.ToInt32(dblHr).ToString() + " glasses of water per hour");
			Console.WriteLine(Convert.ToInt32(dblDay).ToString() + " glasses of water per day");
			Console.WriteLine(Convert.ToInt32(dblWk).ToString() + " glasses of water per week");

			Console.ReadLine();
		}
	}
}
