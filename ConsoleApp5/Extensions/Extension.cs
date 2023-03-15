using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Extensions
{
    internal static class Extension
    {
        public static bool CheckAll(this string correct)
        {
            if (correct == null)
            {
                return false;
            }
            if (correct.Length < 3 || correct.Length > 30)
            {
                return false;
            }
            return true;

        }
    }
}
