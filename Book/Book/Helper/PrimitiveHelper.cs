using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libary.Helper
{
    public static class PrimitiveHelper
    {
        public static string ReadString(string caption, bool allowIsNullOrEmpty = false)
        {
            string income;
        L1:
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(caption);
            Console.ForegroundColor = oldColor;

            income = Console.ReadLine();

            if (allowIsNullOrEmpty == false && string.IsNullOrWhiteSpace(income))
            {
                goto L1;
            }

            return income;
        }

        public static int ReadInt(string caption, int min = 0, int max = 0)
        {
            string income;
        L1:
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine(caption);
            

            if (min == 0 && max == 0)
            {
                Console.WriteLine($"{caption} :");
            }
            else
            {
                Console.WriteLine($"{caption} [{min} {max}]");
            }

            Console.ForegroundColor = oldColor;
            income = Console.ReadLine();

            if (!int.TryParse(income, out int value) || (min!=0 && max!=0 &&( value < min || value>max )))
            {
                goto L1;
            }
            if ( value < min)
            {

                goto L1;

            }

            return value;
        }

    }
}
