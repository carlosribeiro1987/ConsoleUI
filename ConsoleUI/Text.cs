using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI {
    public class Text {
        public static void PrintInColor(string text, ConsoleColor textColor = ConsoleColor.Green, ConsoleColor backgroundColor = ConsoleColor.Black) {
            ConsoleColor tmpTextColor = Console.ForegroundColor;
            ConsoleColor tmpBackColor = Console.BackgroundColor;
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.Write(text);
            Console.ForegroundColor = tmpTextColor;
            Console.BackgroundColor = tmpBackColor;
        }
    }
}
