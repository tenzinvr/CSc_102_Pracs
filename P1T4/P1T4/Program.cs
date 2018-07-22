using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1T4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get drip frequency from user
            Console.WriteLine("Please enter the frequency of the drips (in seconds):");
            string strFreq = Console.ReadLine();
            if int.TryParse(strFreq):
            {
                int intFreq = Convert.ToInt32(strFreq);
            }
            else:
            {
                Console.WriteLine("Error. Incorrect format. Please use integers only.");
                Main();
            }

            //Calculate volume of water wasted per period
            double dblHr = 3600 / intFreq * 0.00025;
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
