using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter change required:");
            double dblChan = Convert.ToDouble(Console.ReadLine());

            List<double> lsChan = new List<double>();
            lsChan.Add(200.0);
            lsChan.Add(100.0);
            lsChan.Add(50.0);
            lsChan.Add(20.0);
            lsChan.Add(10.0);
            lsChan.Add(0.50);
            lsChan.Add(0.20);
            lsChan.Add(0.10);
            lsChan.Add(0.05);
            lsChan.Add(0.02);
            lsChan.Add(0.01);

            List<int> lsCnt = new List<int>(5);

            for (int x = 0; x <= 10; x++)
            {
                lsCnt.Add(0);

                while (dblChan >= lsChan[x])
                {
                    dblChan = dblChan - lsChan[x];
                    lsCnt[x] = lsCnt[x] += 1;
                }
                Console.WriteLine("Return {0} x R{1}", lsCnt[x].ToString(), lsChan[x]);
            }
            Console.ReadKey();
        }
    }
}
