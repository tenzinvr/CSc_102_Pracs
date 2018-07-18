using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
            //Get drip frequency from user
            Console.WriteLine("Please enter the frequency of the drips (in seconds):");
			int intFreq = Convert.ToInt32(Console.ReadLine());

            //Calculate volume of water wasted per period
            double dblHr = 3600/intFreq*0.00025;
			double dblDay = 86400 / intFreq * 0.00025;
			double dblWk = 604800 / intFreq * 0.00025;

            //Display results
            Console.WriteLine("You are wasting;");
			Console.WriteLine(dblHr.ToString() + " liters per hour");
			Console.WriteLine(dblDay.ToString() + " liters per day");
			Console.WriteLine(dblWk.ToString() + " liters per week");

            //Hold console
			Console.ReadLine();
		}
	}
}
