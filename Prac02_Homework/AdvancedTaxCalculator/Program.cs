using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaxCalculator
{
    class Program
    {
        static void Main(string[] lsData)
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
            double dblAge_Av = (FunctAvg(lsAge))[0];
            double dblSal_Av = (FunctAvg(lsSal))[0];
            Console.WriteLine("Average age: " + dblAge_Av.ToString());
            Console.WriteLine("Average Monthly Salary: " + dblSal_Av.ToString());
            Console.WriteLine("Average Monthly Tax: " + Calc(dblAge_Av, dblSal_Av).ToString());

            Console.ReadLine();

        }

        static double Calc(double age, double sal)
        {
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
            int intTax = 0;

            if (age < 65) { intTax = lsBase[intSal]; }
            else if ((age >= 65) && (age <= 75)) { intTax = lsBase[intSal] - lsRed1[intSal]; }
            else { intTax = lsBase[intSal] - lsRed2[intSal]; }

            return intTax;
        }
        static List<double> FunctAvg( List<double> lsData)
        {
            List <double> dblAvg = new List<double> ();
            double dblSum = 0;
            for ( int x = 0; x <= 2; x++)
            {
                dblSum = dblSum + lsData[x];
            }
            dblAvg.Add( dblSum / 3 );
            return dblAvg;
        }

        static void InpErr(string strErr = "valid digits")
        {
            Console.WriteLine("Input Error. Please enter only {0}.", strErr);
        }
    }
}
