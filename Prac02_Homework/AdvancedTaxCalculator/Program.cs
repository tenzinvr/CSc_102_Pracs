using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaxCalculator
{
    class Program
    {
        public static void Main(string[] lsData)
        {
            /*if (!(int.TryParse(Console.ReadLine(), out int intAge))) { InpErr("integers"); Program.Main(); }
            if (!(int.TryParse(Console.ReadLine(), out int intSal))) { InpErr("integers"); Program.Main(); }*/
            List<double> lsAge = new List<double>();
            List<double> lsSal = new List<double>();
            int cnt = 0;
            while ( cnt < lsData.Length )
            {
                if (cnt % 2 == 0)
                {
                    lsSal.Add( Convert.ToDouble(lsData[cnt]) );

                }
                else
                {
                    lsAge.Add( Convert.ToDouble(lsData[cnt]));
                }
                cnt += 1;
            }
            Console.WriteLine("Average age: " + (lsAge.Average()).ToString());
            Console.WriteLine("Average Monthly Salary: " + (lsSal.Average()).ToString());
            Console.WriteLine("Average Monthly Tax: " + (Calc(lsAge, lsSal).Average()).ToString());

            Console.ReadLine();

        }

        public static List<double> Calc(List<double> lsAge, List<double> lsSal)
        {
            List<double> lsTax = new List<double>();

            for (int x = 0; x <= 2; x++)
            {
                double sal = lsSal[x];
                double age = lsAge[x];

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

                int intSal = Convert.ToInt32(sal);

                if (age < 65) { lsTax.Add(lsBase[intSal]); }
                else if ((age >= 65) && (age <= 75)) { lsTax.Add(lsBase[intSal] - lsRed1[intSal]); }
                else { lsTax.Add(lsBase[intSal] - lsRed2[intSal]); }
            
            }
            return lsTax;
        }

        static void InpErr(string strErr = "valid digits")
        {
            Console.WriteLine("Input Error. Please enter only {0}.", strErr);
        }
    }
}
