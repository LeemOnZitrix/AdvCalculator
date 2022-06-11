using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCalculator
{
    internal class ColorExtension
    {
        public static void WriteLineMenu(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public static void WriteLineResult(int result)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(result);
            Console.ResetColor();
        }
        public static void WriteLineResult(string result)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(result);
            Console.ResetColor();
        }
        public static void WriteLineResult(double result)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(result);
            Console.ResetColor();
        }
        public static void WriteLineInfo(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
