using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUI;

namespace SampleBoxes {
    class Program {
        static void Main(string[] args) {
            //Simple Box
            Console.WriteLine("\n\tSIMPLE BOX:");
            Console.Write(ConsoleBox.Draw(new string[] { "First Line", "Second Line", "Third Line" }));
            Console.WriteLine("");
            //Simple Box (Width = 40 chars)
            Console.WriteLine("\tSIMPLE BOX, Width = 40 chars:");
            Console.Write(ConsoleBox.Draw(new string[] { "First Line", "Second Line", "Third Line" }, 40));
            //Titled Box
            Console.WriteLine("\tTITLED BOX:");
            Console.Write(ConsoleBox.Draw("BOX TITLE", new string[] { "First Line", "Second Line", "Third Line" }));
            Console.WriteLine("");
            //Titled Box (Width = 40 chars)
            Console.WriteLine("\tTITLED BOX, Width = 40 chars:");
            Console.Write(ConsoleBox.Draw("BOX TITLE", new string[] { "First Line", "Second Line", "Third Line" }, 40));

            Console.ReadKey();
        }
    }
}