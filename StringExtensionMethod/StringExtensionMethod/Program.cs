using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "This is a sentence";
            var numberOfWords = sentence.WordCount();
        }
    }
}
