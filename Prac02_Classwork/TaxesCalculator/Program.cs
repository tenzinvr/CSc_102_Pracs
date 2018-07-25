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
            //int red = 0;
            int lsRed[];
            int lsRed1[10] = { 0, 13, 250, 620, 600, 600, 700, 500, 400, 2950 };
            int lsRed2[10] = { 0, 13, 250, 620, 800, 900, 900, 700, 600, 3000 };

            if (age < 65) { int lsRed = 0; }
            else if ((age >= 65) && (age <= 75)) { lsRed = lsRed1; }
            else { lsRed = lsRed2;  }

            if ((sal > 0) && (sal < 5000)) { sal = 0; }
            else if ((sal >= 5000) && (sal < 6500)) { sal = 1; }


            string strTax = "";
            return strTax;
        }

        static void InpErr(string strErr = "valid digits")
        {
            Console.WriteLine("Input Error. Please enter only {0}." , strErr);
        }
    }
}
