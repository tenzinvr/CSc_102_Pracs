using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter change required:");
            double dblChan = Convert.ToDouble(Console.ReadLine());

            while (dblChan > 0)
            {
                //int cnt200 = 0, cnt100 = 0, cnt50 = 0, cnt20 = 0, cnt10 = 0, cnt5 = 0, cnt2 = 0, cnt1 = 0, cnt05 = 0, cnt02 = 0, cnt01 = 0, cnt005 = 0, cnt002 = 0, cnt001 = 0;

                /*if (dblChan >= 200) { dblChan = dblChan - 200; cnt200 += 1; }
                else if (dblChan >= 100) { dblChan = dblChan - 100; cnt100 += 1; }
                else if (dblChan >= 50) { dblChan = dblChan - 50; cnt50 += 1; }
                else if (dblChan >= 20) { dblChan = dblChan - 20; cnt20 += 1; }
                else if (dblChan >= 10) { dblChan = dblChan - 10; cnt10 += 1; }
                else if (dblChan >= 5) { dblChan = dblChan - 5; cnt5 += 1; }
                else if (dblChan >= 2) { dblChan = dblChan - 2; cnt2 += 1; }
                else if (dblChan >= 1) { dblChan = dblChan - 1; cnt1 += 1; }
                else if (dblChan >= 0.5) { dblChan = dblChan - 0.5; cnt05 += 1; }
                else if (dblChan >= 0.2) { dblChan = dblChan - 0.2; cnt02 += 1; }
                else if (dblChan >= 0.1) { dblChan = dblChan - 0.1; cnt01 += 1; }
                else if (dblChan >= 0.05) { dblChan = dblChan - 0.05; cnt005 += 1; }
                else if (dblChan >= 0.02) { dblChan = dblChan - 0.02; cnt002 += 1; }
                else if (dblChan >= 0.01) { dblChan = dblChan - 0.01; cnt001 += 1; }
                else { break; }*/

                double[] lsChan = new double[] { 200, 100, 50, 20, 10 };
                int[] lsCnt = new int[] { };
                for (int x = 0; x <= 5; x += 1)
                {
                    while (dblChan >= lsChan[x])
                    {
                        dblChan = dblChan - lsChan[x];
                        lsCnt[x] += 1;
                    }
                }

                Console.WriteLine("Change Succ");
                Console.WriteLine("Return {0} x R200", lsCnt[0].ToString());
                Console.WriteLine("Return {0} x R100", lsCnt[1].ToString());
            }
        }
    }
}
