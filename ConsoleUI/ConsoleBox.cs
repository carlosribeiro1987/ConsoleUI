using System;

namespace ConsoleUI {
    public class ConsoleBox {
        /// <summary>
        /// 
        /// </summary>
        public enum BoxType { Light, Double, HalfBlock, Block, LightShade, MediumShade, DarkShade }
        /// <summary>
        /// Draws a box arround a text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>The box.</returns>
        public static string Draw(string[] text, BoxType boxType = BoxType.Double) {
            
            string topLine = "";
            string bottomLine = "";
            string textLine = "";
            string blankLine = "";
            string box = "";
            int textLength = text[0].Length;
            //Get the length of the longest string in array
            for (int i = 0; i < text.Length; i++) {
                if (text[i].Length > textLength)
                    textLength = text[i].Length;
            }
            
            switch (boxType) {
                case BoxType.Light:
                    //Top Line
                    topLine += "\t┌";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "─";
                    topLine += "┐\n";
                    //Blank Line
                    blankLine = "\t│";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "│\n";
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t│ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " │\n";
                    }
                    //Bottom Line
                    bottomLine += "\t└";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "─";
                    bottomLine += "┘\n";
                    break;
                case BoxType.Double:
                    topLine += "\t╔";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "═";
                    topLine += "╗\n";
                    //Blank Line
                    blankLine = "\t║";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "║\n";
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t║ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " ║\n";
                    }
                    //Bottom Line
                    bottomLine += "\t╚";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "═";
                    bottomLine += "╝\n";
                    break;
                case BoxType.HalfBlock:
                    topLine += "\t▄";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "▄";
                    topLine += "▄\n";
                    //Blank Line
                    blankLine = "\t▌";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "▐\n";
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t▌ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " ▐\n";
                    }
                    //Bottom Line
                    bottomLine += "\t▀";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "▀";
                    bottomLine += "▀\n";
                    break;
                case BoxType.Block:
                    topLine += "\t█";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "█";
                    topLine += "█\n";
                    //Blank Line
                    blankLine = "\t█";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "█\n";
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t█ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " █\n";
                    }
                    //Bottom Line
                    bottomLine += "\t█";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "█";
                    bottomLine += "█\n";
                    break;
                case BoxType.LightShade:
                    topLine += "\t░";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "░";
                    topLine += "░\n";
                    //Blank Line
                    blankLine = "\t░";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "░\n";
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t░ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " ░\n";
                    }
                    //Bottom Line
                    bottomLine += "\t░";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "░";
                    bottomLine += "░\n";
                    break;
                case BoxType.MediumShade:
                    topLine += "\t▒";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "▒";
                    topLine += "▒\n";
                    //Blank Line
                    blankLine = "\t▒";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "▒\n";
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t▒ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " ▒\n";
                    }
                    //Bottom Line
                    bottomLine += "\t▒";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "▒";
                    bottomLine += "▒\n";
                    break;
                case BoxType.DarkShade:
                    topLine += "\t▓";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "▓";
                    topLine += "▓\n";
                    //Blank Line
                    blankLine = "\t▓";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "▓\n";
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t▓ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " ▓\n";
                    }
                    //Bottom Line
                    bottomLine += "\t▓";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "▓";
                    bottomLine += "▓\n";
                    break;
            }
            
            box = string.Format("\n{0}{1}{2}{3}{4}\n", topLine, blankLine, textLine, blankLine, bottomLine);
            return box;
        }
        /// <summary>
        /// Draws a box arround a text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="width">Width of the box (# of chars).</param>
        /// <returns>The box.</returns>
        public static string Draw(string[] text, int width, BoxType boxType = BoxType.Double) {
            string topLine = "";
            string bottomLine = "";
            string textLine = "";
            string blankLine = "";
            string box = "";
            int textLength = text[0].Length;
            //Get the length of the longest string in array
            for (int i = 0; i < text.Length; i++) {
                if (text[i].Length > textLength)
                    textLength = text[i].Length;
            }
            if (textLength <= width)
                textLength = width;
            try { //Adjust the box width to fit the console window
                if (textLength > Console.WindowWidth - 20)
                    textLength = Console.WindowWidth - 20;
            }
            catch(Exception e) {
                Console.WriteLine("Error: " + e.Message);
            }
            switch (boxType) {
                case BoxType.Light: //└ ┘ ┌ ┐ │ ─
                    //Top Line
                    topLine += "\t┌";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "─";
                    topLine += "┐\n";
                    //Blank Line
                    blankLine = "\t│";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "│\n";
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t│ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " │\n";
                    }
                    //Bottom Line
                    bottomLine += "\t└";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "─";
                    bottomLine += "┘\n";
                    break;
                case BoxType.Double:
                    //Top Line
                    topLine += "\t╔";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "═";
                    topLine += "╗\n";
                    //Blank Line
                    blankLine = "\t║";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "║\n";
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t║ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " ║\n";
                    }
                    //Bottom Line
                    bottomLine += "\t╚";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "═";
                    bottomLine += "╝\n";
                    break;
                case BoxType.HalfBlock: // ▀ ▄ ▌▐
                    //Top Line
                    topLine += "\t▄";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "▄";
                    topLine += "▄\n";
                    //Blank Line
                    blankLine = "\t▌";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "▐\n";
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t▌ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " ▐\n";
                    }
                    //Bottom Line
                    bottomLine += "\t▀";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "▀";
                    bottomLine += "▀\n";
                    break;
                case BoxType.Block:
                    //Top Line
                    topLine += "\t█";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "█";
                    topLine += "█\n";
                    //Blank Line
                    blankLine = "\t█";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "█\n";
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t█ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " █\n";
                    }
                    //Bottom Line
                    bottomLine += "\t█";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "█";
                    bottomLine += "█\n";
                    break;
                case BoxType.LightShade:
                    //Top Line
                    topLine += "\t░";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "░";
                    topLine += "░\n";
                    //Blank Line
                    blankLine = "\t░";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "░\n";
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t░ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " ░\n";
                    }
                    //Bottom Line
                    bottomLine += "\t░";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "░";
                    bottomLine += "░\n";
                    break;
                case BoxType.MediumShade:
                    //Top Line
                    topLine += "\t▒";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "▒";
                    topLine += "▒\n";
                    //Blank Line
                    blankLine = "\t▒";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "▒\n";
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t▒ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " ▒\n";
                    }
                    //Bottom Line
                    bottomLine += "\t▒";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "▒";
                    bottomLine += "▒\n";
                    break;
                case BoxType.DarkShade:
                    //Top Line
                    topLine += "\t▓";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "▓";
                    topLine += "▓\n";
                    //Blank Line
                    blankLine = "\t▓";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "▓\n";
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t▓ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " ▓\n";
                    }
                    //Bottom Line
                    bottomLine += "\t▓";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "▓";
                    bottomLine += "▓\n";
                    break;
            }
            
            box = string.Format("\n{0}{1}{2}{3}{4}\n", topLine, blankLine, textLine, blankLine, bottomLine);
            return box;
        }

        /// <summary>
        /// Draws a titled box arround the text.
        /// </summary>
        /// <param name="title">The title of the box</param>
        /// <param name="text">The text</param>
        /// <returns>The titled box.</returns>
        public static string Draw(string title, string[] text,  BoxType boxType = BoxType.Double) {
            string topLine = "";
            string bottomLine = "";
            string textLine = "";
            string blankLine = "";
            string titleLine = "";
            string titleBottomLine = "";
            string box = "";
            int textLength = text[0].Length;
            //Get the length of the longest string in array
            for (int i = 0; i < text.Length; i++) {
                if (text[i].Length > textLength)
                    textLength = text[i].Length;
            }
            if (textLength < title.Length)
                textLength = title.Length;
            switch (boxType) {
                case BoxType.Light: //└ ┘ ┌ ┐ │ ─ ├ ┤
                    //Top Line
                    topLine += "\t┌";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "─";
                    topLine += "┐\n";
                    //Bottom Line
                    bottomLine += "\t└";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "─";
                    bottomLine += "┘\n";
                    //Title Separator
                    titleBottomLine += "\t├";
                    for (int i = 0; i < textLength + 2; i++)
                        titleBottomLine += "─";
                    titleBottomLine += "┤\n";
                    //Blank Line
                    blankLine = "\t│";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "│\n";
                    //Title Line
                    titleLine += "\t│ ";
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += title;
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += " │\n";
                    if (titleLine.Length < topLine.Length) {
                        string temp;
                        while (titleLine.Length < topLine.Length) {
                            temp = titleLine.Insert(titleLine.IndexOf('\n') - 1, " ");
                            titleLine = temp;
                        }
                    }
                    else if (titleLine.Length > topLine.Length) {
                        string temp;
                        while (titleLine.Length > topLine.Length) {
                            temp = titleLine.Remove(titleLine.IndexOf('\n') - 1, 1);
                            titleLine = temp;
                        }
                    }
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t│ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " │\n";
                    }
                    break;
                case BoxType.Double:
                    //Top Line
                    topLine += "\t╔";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "═";
                    topLine += "╗\n";
                    //Bottom Line
                    bottomLine += "\t╚";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "═";
                    bottomLine += "╝\n";
                    //Title Separator
                    titleBottomLine += "\t╠";
                    for (int i = 0; i < textLength + 2; i++)
                        titleBottomLine += "═";
                    titleBottomLine += "╣\n";
                    //Blank Line
                    blankLine = "\t║";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "║\n";
                    //Title Line
                    titleLine += "\t║ ";
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += title;
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += " ║\n";
                    if (titleLine.Length < topLine.Length) {
                        string temp;
                        while (titleLine.Length < topLine.Length) {
                            temp = titleLine.Insert(titleLine.IndexOf('\n') - 1, " ");
                            titleLine = temp;
                        }
                    }
                    else if (titleLine.Length > topLine.Length) {
                        string temp;
                        while (titleLine.Length > topLine.Length) {
                            temp = titleLine.Remove(titleLine.IndexOf('\n') - 1, 1);
                            titleLine = temp;
                        }
                    }
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t║ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " ║\n";
                    }
                    break;
                case BoxType.HalfBlock: // ▀ ▄ ▌ ▐
                    //Top Line
                    topLine += "\t▄";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "▄";
                    topLine += "▄\n";
                    //Bottom Line
                    bottomLine += "\t▀";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "▀";
                    bottomLine += "▀\n";
                    //Title Separator
                    titleBottomLine += "\t▐";
                    for (int i = 0; i < textLength + 2; i++)
                        titleBottomLine += "▀";
                    titleBottomLine += "▌\n";
                    //Blank Line
                    blankLine = "\t▐";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "▌\n";
                    //Title Line
                    titleLine += "\t▐ ";
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += title;
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += " ▌\n";
                    if (titleLine.Length < topLine.Length) {
                        string temp;
                        while (titleLine.Length < topLine.Length) {
                            temp = titleLine.Insert(titleLine.IndexOf('\n') - 1, " ");
                            titleLine = temp;
                        }
                    }
                    else if (titleLine.Length > topLine.Length) {
                        string temp;
                        while (titleLine.Length > topLine.Length) {
                            temp = titleLine.Remove(titleLine.IndexOf('\n') - 1, 1);
                            titleLine = temp;
                        }
                    }
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t▐ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " ▌\n";
                    }
                    break;
                case BoxType.Block:
                    //Top Line
                    topLine += "\t█";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "█";
                    topLine += "█\n";
                    //Bottom Line
                    bottomLine += "\t█";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "█";
                    bottomLine += "█\n";
                    //Title Separator
                    titleBottomLine += "\t█";
                    for (int i = 0; i < textLength + 2; i++)
                        titleBottomLine += "█";
                    titleBottomLine += "█\n";
                    //Blank Line
                    blankLine = "\t█";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "█\n";
                    //Title Line
                    titleLine += "\t█ ";
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += title;
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += " █\n";
                    if (titleLine.Length < topLine.Length) {
                        string temp;
                        while (titleLine.Length < topLine.Length) {
                            temp = titleLine.Insert(titleLine.IndexOf('\n') - 1, " ");
                            titleLine = temp;
                        }
                    }
                    else if (titleLine.Length > topLine.Length) {
                        string temp;
                        while (titleLine.Length > topLine.Length) {
                            temp = titleLine.Remove(titleLine.IndexOf('\n') - 1, 1);
                            titleLine = temp;
                        }
                    }
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t█ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " █\n";
                    }
                    break;
                case BoxType.LightShade:
                    //Top Line
                    topLine += "\t░";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "░";
                    topLine += "░\n";
                    //Bottom Line
                    bottomLine += "\t░";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "░";
                    bottomLine += "░\n";
                    //Title Separator
                    titleBottomLine += "\t░";
                    for (int i = 0; i < textLength + 2; i++)
                        titleBottomLine += "░";
                    titleBottomLine += "░\n";
                    //Blank Line
                    blankLine = "\t░";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "░\n";
                    //Title Line
                    titleLine += "\t░ ";
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += title;
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += " ░\n";
                    if (titleLine.Length < topLine.Length) {
                        string temp;
                        while (titleLine.Length < topLine.Length) {
                            temp = titleLine.Insert(titleLine.IndexOf('\n') - 1, " ");
                            titleLine = temp;
                        }
                    }
                    else if (titleLine.Length > topLine.Length) {
                        string temp;
                        while (titleLine.Length > topLine.Length) {
                            temp = titleLine.Remove(titleLine.IndexOf('\n') - 1, 1);
                            titleLine = temp;
                        }
                    }
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t░ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " ░\n";
                    }
                    break;
                case BoxType.MediumShade:
                    //Top Line
                    topLine += "\t▒";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "▒";
                    topLine += "▒\n";
                    //Bottom Line
                    bottomLine += "\t▒";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "▒";
                    bottomLine += "▒\n";
                    //Title Separator
                    titleBottomLine += "\t▒";
                    for (int i = 0; i < textLength + 2; i++)
                        titleBottomLine += "▒";
                    titleBottomLine += "▒\n";
                    //Blank Line
                    blankLine = "\t▒";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "▒\n";
                    //Title Line
                    titleLine += "\t▒ ";
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += title;
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += " ▒\n";
                    if (titleLine.Length < topLine.Length) {
                        string temp;
                        while (titleLine.Length < topLine.Length) {
                            temp = titleLine.Insert(titleLine.IndexOf('\n') - 1, " ");
                            titleLine = temp;
                        }
                    }
                    else if (titleLine.Length > topLine.Length) {
                        string temp;
                        while (titleLine.Length > topLine.Length) {
                            temp = titleLine.Remove(titleLine.IndexOf('\n') - 1, 1);
                            titleLine = temp;
                        }
                    }
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t▒ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " ▒\n";
                    }
                    break;
                case BoxType.DarkShade:
                    //Top Line
                    topLine += "\t▓";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "▓";
                    topLine += "▓\n";
                    //Bottom Line
                    bottomLine += "\t▓";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "▓";
                    bottomLine += "▓\n";
                    //Title Separator
                    titleBottomLine += "\t▓";
                    for (int i = 0; i < textLength + 2; i++)
                        titleBottomLine += "▓";
                    titleBottomLine += "▓\n";
                    //Blank Line
                    blankLine = "\t▓";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "▓\n";
                    //Title Line
                    titleLine += "\t▓ ";
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += title;
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += " ▓\n";
                    if (titleLine.Length < topLine.Length) {
                        string temp;
                        while (titleLine.Length < topLine.Length) {
                            temp = titleLine.Insert(titleLine.IndexOf('\n') - 1, " ");
                            titleLine = temp;
                        }
                    }
                    else if (titleLine.Length > topLine.Length) {
                        string temp;
                        while (titleLine.Length > topLine.Length) {
                            temp = titleLine.Remove(titleLine.IndexOf('\n') - 1, 1);
                            titleLine = temp;
                        }
                    }
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t▓ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " ▓\n";
                    }
                    break;
            }
            
            box = string.Format("\n{0}{1}{2}{3}{4}{5}{6}\n", topLine, titleLine, titleBottomLine, blankLine, textLine, blankLine, bottomLine);
            return box;

        }

        /// <summary>
        /// Draws a titled box arround the text
        /// </summary>
        /// <param name="title">The box title.</param>
        /// <param name="text">The text.</param>
        /// <param name="width">The box width (# of chars).</param>
        /// <returns></returns>
        public static string Draw(string title, string[] text, int width, BoxType boxType = BoxType.Double) {
            string topLine = "";
            string bottomLine = "";
            string textLine = "";
            string blankLine = "";
            string titleLine = "";
            string titleBottomLine = "";
            string box = "";
            int textLength = text[0].Length;
            //Get the length of the longest string in array
            for (int i = 0; i < text.Length; i++) {
                if (text[i].Length > textLength)
                    textLength = text[i].Length;
            }
            if (textLength < title.Length)
                textLength = title.Length;
            if (textLength <= width)
                textLength = width;
            try { //Adjust the box width to fit the console window
                if (textLength > Console.WindowWidth - 20)
                    textLength = Console.WindowWidth - 20;
            }
            catch (Exception e) {
                Console.WriteLine("Error: " + e.Message);
            }

            switch (boxType) {
                case BoxType.Light: //└ ┘ ┌ ┐ │ ─ ├ ┤
                    //Top Line
                    topLine += "\t┌";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "─";
                    topLine += "┐\n";
                    //Bottom Line
                    bottomLine += "\t└";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "─";
                    bottomLine += "┘\n";
                    //Title Separator
                    titleBottomLine += "\t├";
                    for (int i = 0; i < textLength + 2; i++)
                        titleBottomLine += "─";
                    titleBottomLine += "┤\n";
                    //Blank Line
                    blankLine = "\t│";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "│\n";
                    //Title Line
                    titleLine += "\t│ ";
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += title;
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += " │\n";
                    if (titleLine.Length < topLine.Length) {
                        string temp;
                        while (titleLine.Length < topLine.Length) {
                            temp = titleLine.Insert(titleLine.IndexOf('\n') - 1, " ");
                            titleLine = temp;
                        }
                    }
                    else if (titleLine.Length > topLine.Length) {
                        string temp;
                        while (titleLine.Length > topLine.Length) {
                            temp = titleLine.Remove(titleLine.IndexOf('\n') - 1, 1);
                            titleLine = temp;
                        }
                    }
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t│ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " │\n";
                    }
                    break;
                case BoxType.Double:
                    //Top Line
                    topLine += "\t╔";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "═";
                    topLine += "╗\n";
                    //Bottom Line
                    bottomLine += "\t╚";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "═";
                    bottomLine += "╝\n";
                    //Title Separator
                    titleBottomLine += "\t╠";
                    for (int i = 0; i < textLength + 2; i++)
                        titleBottomLine += "═";
                    titleBottomLine += "╣\n";
                    //Blank Line
                    blankLine = "\t║";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "║\n";
                    //Title Line
                    titleLine += "\t║ ";
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += title;
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += " ║\n";
                    if (titleLine.Length < topLine.Length) {
                        string temp;
                        while (titleLine.Length < topLine.Length) {
                            temp = titleLine.Insert(titleLine.IndexOf('\n') - 1, " ");
                            titleLine = temp;
                        }
                    }
                    else if (titleLine.Length > topLine.Length) {
                        string temp;
                        while (titleLine.Length > topLine.Length) {
                            temp = titleLine.Remove(titleLine.IndexOf('\n') - 1, 1);
                            titleLine = temp;
                        }
                    }
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t║ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " ║\n";
                    }
                    break;
                case BoxType.HalfBlock: //▀ ▄ ▌ ▐
                    //Top Line
                    topLine += "\t▄";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "▄";
                    topLine += "▄\n";
                    //Bottom Line
                    bottomLine += "\t▀";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "▀";
                    bottomLine += "▀\n";
                    //Title Separator
                    titleBottomLine += "\t▐";
                    for (int i = 0; i < textLength + 2; i++)
                        titleBottomLine += "▀";
                    titleBottomLine += "▌\n";
                    //Blank Line
                    blankLine = "\t▐";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "▌\n";
                    //Title Line
                    titleLine += "\t▐ ";
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += title;
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += " ▌\n";
                    if (titleLine.Length < topLine.Length) {
                        string temp;
                        while (titleLine.Length < topLine.Length) {
                            temp = titleLine.Insert(titleLine.IndexOf('\n') - 1, " ");
                            titleLine = temp;
                        }
                    }
                    else if (titleLine.Length > topLine.Length) {
                        string temp;
                        while (titleLine.Length > topLine.Length) {
                            temp = titleLine.Remove(titleLine.IndexOf('\n') - 1, 1);
                            titleLine = temp;
                        }
                    }
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t▐ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " ▌\n";
                    }
                    break;
                case BoxType.Block:
                    //Top Line
                    topLine += "\t█";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "█";
                    topLine += "█\n";
                    //Bottom Line
                    bottomLine += "\t█";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "█";
                    bottomLine += "█\n";
                    //Title Separator
                    titleBottomLine += "\t█";
                    for (int i = 0; i < textLength + 2; i++)
                        titleBottomLine += "█";
                    titleBottomLine += "█\n";
                    //Blank Line
                    blankLine = "\t█";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "█\n";
                    //Title Line
                    titleLine += "\t█ ";
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += title;
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += " █\n";
                    if (titleLine.Length < topLine.Length) {
                        string temp;
                        while (titleLine.Length < topLine.Length) {
                            temp = titleLine.Insert(titleLine.IndexOf('\n') - 1, " ");
                            titleLine = temp;
                        }
                    }
                    else if (titleLine.Length > topLine.Length) {
                        string temp;
                        while (titleLine.Length > topLine.Length) {
                            temp = titleLine.Remove(titleLine.IndexOf('\n') - 1, 1);
                            titleLine = temp;
                        }
                    }
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t█ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " █\n";
                    }
                    break;
                case BoxType.LightShade:
                    //Top Line
                    topLine += "\t░";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "░";
                    topLine += "░\n";
                    //Bottom Line
                    bottomLine += "\t░";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "░";
                    bottomLine += "░\n";
                    //Title Separator
                    titleBottomLine += "\t░";
                    for (int i = 0; i < textLength + 2; i++)
                        titleBottomLine += "░";
                    titleBottomLine += "░\n";
                    //Blank Line
                    blankLine = "\t░";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "░\n";
                    //Title Line
                    titleLine += "\t░ ";
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += title;
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += " ░\n";
                    if (titleLine.Length < topLine.Length) {
                        string temp;
                        while (titleLine.Length < topLine.Length) {
                            temp = titleLine.Insert(titleLine.IndexOf('\n') - 1, " ");
                            titleLine = temp;
                        }
                    }
                    else if (titleLine.Length > topLine.Length) {
                        string temp;
                        while (titleLine.Length > topLine.Length) {
                            temp = titleLine.Remove(titleLine.IndexOf('\n') - 1, 1);
                            titleLine = temp;
                        }
                    }
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t░ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " ░\n";
                    }
                    break;
                case BoxType.MediumShade:
                    //Top Line
                    topLine += "\t▒";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "▒";
                    topLine += "▒\n";
                    //Bottom Line
                    bottomLine += "\t▒";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "▒";
                    bottomLine += "▒\n";
                    //Title Separator
                    titleBottomLine += "\t▒";
                    for (int i = 0; i < textLength + 2; i++)
                        titleBottomLine += "▒";
                    titleBottomLine += "▒\n";
                    //Blank Line
                    blankLine = "\t▒";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "▒\n";
                    //Title Line
                    titleLine += "\t▒ ";
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += title;
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += " ▒\n";
                    if (titleLine.Length < topLine.Length) {
                        string temp;
                        while (titleLine.Length < topLine.Length) {
                            temp = titleLine.Insert(titleLine.IndexOf('\n') - 1, " ");
                            titleLine = temp;
                        }
                    }
                    else if (titleLine.Length > topLine.Length) {
                        string temp;
                        while (titleLine.Length > topLine.Length) {
                            temp = titleLine.Remove(titleLine.IndexOf('\n') - 1, 1);
                            titleLine = temp;
                        }
                    }
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t▒ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " ▒\n";
                    }
                    break;
                case BoxType.DarkShade:
                    //Top Line
                    topLine += "\t▓";
                    for (int i = 0; i < textLength + 2; i++)
                        topLine += "▓";
                    topLine += "▓\n";
                    //Bottom Line
                    bottomLine += "\t▓";
                    for (int i = 0; i < textLength + 2; i++)
                        bottomLine += "▓";
                    bottomLine += "▓\n";
                    //Title Separator
                    titleBottomLine += "\t▓";
                    for (int i = 0; i < textLength + 2; i++)
                        titleBottomLine += "▓";
                    titleBottomLine += "▓\n";
                    //Blank Line
                    blankLine = "\t▓";
                    for (int i = 0; i < textLength + 2; i++)
                        blankLine += " ";
                    blankLine += "▓\n";
                    //Title Line
                    titleLine += "\t▓ ";
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += title;
                    for (int i = 0; i < (textLength - title.Length) / 2; i++)
                        titleLine += " ";
                    titleLine += " ▓\n";
                    if (titleLine.Length < topLine.Length) {
                        string temp;
                        while (titleLine.Length < topLine.Length) {
                            temp = titleLine.Insert(titleLine.IndexOf('\n') - 1, " ");
                            titleLine = temp;
                        }
                    }
                    else if (titleLine.Length > topLine.Length) {
                        string temp;
                        while (titleLine.Length > topLine.Length) {
                            temp = titleLine.Remove(titleLine.IndexOf('\n') - 1, 1);
                            titleLine = temp;
                        }
                    }
                    //Text Lines
                    for (int i = 0; i < text.Length; i++) {
                        textLine += "\t▓ " + text[i];
                        for (int j = 0; j < textLength - text[i].Length; j++) {
                            textLine += " ";
                        }
                        textLine += " ▓\n";
                    }
                    break;
            }
            
            box = string.Format("\n{0}{1}{2}{3}{4}{5}{6}\n", topLine, titleLine, titleBottomLine, blankLine, textLine, blankLine, bottomLine);
            return box;
        }
    }
}
