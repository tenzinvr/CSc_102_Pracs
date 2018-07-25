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
            Console.WriteLine("Your monthly tax is " + Calc(intAge, intSal).ToString() );
            Console.ReadLine();

        }

        static int Calc(int age, int sal)
        {
            //int red = 0;
            int[] lsBase = new int[10] { 0, 13, 250, 620, 1200, 2100, 2700, 8000, 16000, 20000 };
            int[] lsRed1 = new int[] { 0, 13, 250, 620, 600, 600, 700, 500, 400, 2950 };
            int[] lsRed2 = new int[] { 0, 13, 250, 620, 800, 900, 900, 700, 600, 3000 };

            if ((sal > 0) && (sal < 5000)) { sal = 0; }
            else if ((sal >= 5000) && (sal < 6500)) { sal = 1; }
            else if ((sal >= 6500) && (sal < 7799)) { sal = 2; }
            else if ((sal >= 7799) && (sal < 9999)) { sal = 3; }
            else if ((sal >= 9999) && (sal < 13499)) { sal = 4; }
            else if ((sal >= 13499) && (sal < 17899)) { sal = 5; }
            else if ((sal >= 17899) && (sal < 19999)) { sal = 6; }
            else if ((sal >= 19999) && (sal < 39999)) { sal = 7; }
            else if ((sal >= 39999) && (sal < 59999)) { sal = 8; }
            else { sal = 9; }

            int intTax = 0;
            
            if (age < 65) { intTax = lsBase[sal]; }
            else if ((age >= 65) && (age <= 75)) { intTax = lsBase[sal] - lsRed1[sal]; }
            else { intTax = lsBase[sal] - lsRed2[sal]; }
            Console.WriteLine(intTax.ToString());
            return intTax;
        }

        static void InpErr(string strErr = "valid digits")
        {
            Console.WriteLine("Input Error. Please enter only {0}." , strErr);
        }
    }
}
