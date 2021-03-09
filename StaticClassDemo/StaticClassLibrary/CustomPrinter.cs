using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassLibrary
{
    public static class CustomPrinter
    {
        public static string QuoteIt(string theQuote, string author) //Anything in a static class must also use static keyword
        {
            return $"'{theQuote}' - {author}";
        }
    }
}
