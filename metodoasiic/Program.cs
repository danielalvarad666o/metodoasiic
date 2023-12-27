using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodoasiic
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "ABCDEFGHI";
            byte[] ASCIIvalues = Encoding.ASCII.GetBytes(str);
            foreach (var value in ASCIIvalues)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
    }
}
