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
			//Get drip frequency from user
			Console.WriteLine("Please enter the frequency of the drips (in seconds):");
			int intFreq = Convert.ToInt32(Console.ReadLine());

			//Calculate volume of water wasted per period
			double dblHr = 3600 / intFreq * 0.00025;
			double dblDay = 86400 / intFreq * 0.00025;
			double dblWk = 604800 / intFreq * 0.00025;

            //Display results
            Console.WriteLine("You are wasting;");
            //Divide result by 4 and convert to an integer to have number of glasses
			Console.WriteLine(Convert.ToInt32(dblHr/4).ToString() + " glasses of water per hour");
			Console.WriteLine(Convert.ToInt32(dblDay/4).ToString() + " glasses of water per day");
			Console.WriteLine(Convert.ToInt32(dblWk/4).ToString() + " glasses of water per week");

            //Hold console
			Console.ReadLine();
		}
	}
}
