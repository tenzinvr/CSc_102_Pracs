using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your age:");
            if (!(int.TryParse(Console.ReadLine(), out int intAge))) { InpErr("integers"); Program.Main(); }
            Console.WriteLine("Please enter your monthly salary:");
            if (!(int.TryParse(Console.ReadLine(), out int intSal))) { InpErr("integers"); Program.Main(); }
            Console.WriteLine("Your monthly tax is ", Calc(intAge, intSal));
            Console.ReadLine();

        }

        static string Calc(int age, int sal)
        {
            int red = 0;
            Array lsRed1 = new Array[13, 250, 620, 600, 600, 700, 500, 400, 2950];
            if ((age >= 65) && (age <= 75)) { Array lsRed = lsRed1[sal]; }
            string strTax = "";
            return strTax;
        }

        static void InpErr(string strErr = "valid digits")
        {
            Console.WriteLine("Input Error. Please enter only {0}." , strErr);
        }
    }
}
