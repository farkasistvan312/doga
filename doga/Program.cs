using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bankjegyautomata");
            Console.WriteLine("min címlet 1000 Ft, max 300 000 Ft");
            Console.Write("add meg az összeget! ");
            int ossz = Convert.ToInt32(Console.ReadLine());
            int tiz = 0;
            int ot = 0;
            int ezer = 0;
            int osszketto = ossz;
            if (ossz % 1000 == 0)
            {
                tiz = ossz / 10000;
                ossz = ossz - (tizezer * 10000);
                ot = ossz / 5000;
                ossz = ossz - (otezer * 5000);
                ezer = ossz / 1000;
                Console.WriteLine(tizezer + " * 10000 = " + (tiz * 10000));
                Console.WriteLine(otezer + " * 5000 = " + (ot * 5000));
                Console.WriteLine(ezer + " * 1000 = " + (ezer * 1000));
                Console.WriteLine("Összeg: " + osszketto + " Ft");
         
            Console.ReadKey();
        }
    }
}
