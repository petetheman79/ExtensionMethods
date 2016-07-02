using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensionMethod
{
    public static class Utils
    {
        public static int WordCount(this string str)
        {
            return str.Split(' ').Count();
        }
    }
}
