using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPG6
{
    static class TextManager
    {
        public static string InputFormat(string input)
        {
            return input.Trim().ToLower();
        }

        public static string OutputFormat(string input)
        {
            return input.Trim().ToUpper();
        }
    }
}
