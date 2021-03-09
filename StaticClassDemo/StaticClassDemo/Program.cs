using StaticClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = CustomPrinter.QuoteIt("640K ought to be enough memory for anyone", "Bill Gates");
            Console.WriteLine(quote);

            Console.ReadLine();
        }
    }
}
