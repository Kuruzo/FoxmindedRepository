using System;
using System.Collections.Generic;
using static System.Console;


namespace ConsoleApplications
{
    class Anagram
    {
        protected static string tempString = null;
        public static void StartProgram()
        {
            // Introdaction user and reading data
            WriteLine("Welcome to program: <Anagram>.");
            WriteLine("Write same string and press <Enter> then you end.");
            Write("Same string: ");
            ForegroundColor = ConsoleColor.Yellow;
            string inputString = ReadLine() + " ";
            ForegroundColor = ConsoleColor.Gray;
            Write("Answere is: ");

            // Work with words
            foreach (char item in inputString)
            {
                if (item == ' ')
                {
                    WriteAnagram(tempString);
                    tempString = null;
                }
                else
                {
                    tempString += item;
                }
            }

        }

        // List of matching symbols
        static bool IsTrueLetter(char inputChar)
        {
            if ((65 <= Convert.ToInt32(inputChar) && Convert.ToInt32(inputChar) <= 90)
                || (97 <= Convert.ToInt32(inputChar) && Convert.ToInt32(inputChar) <= 122)
                ) return true;
            else return false;
        }

        // Remake 1 word
        public static string WriteAnagram(string inputString)
        {
            string result = null;
            Dictionary<int, char> word = new Dictionary<int, char>();

            // Fill the tempWord so [<number><letter>]
            for (int i = 0; i < inputString.Length; i++)
            {
                word.Add(i, inputString[i]);
            }

            // Make anagram
            int fromStart = 0, fromEnd = inputString.Length - 1;
            while (true)
            {
                if (fromStart >= fromEnd) break;
                if (!IsTrueLetter(word[fromStart]))
                {
                    fromStart++;
                    continue;
                }
                if (!IsTrueLetter(word[fromEnd]))
                {
                    fromEnd--;
                    continue;
                }
                if (IsTrueLetter(word[fromStart]) && IsTrueLetter(word[fromEnd]))
                {
                    char tempChar = word[fromStart];
                    word[fromStart] = word[fromEnd];
                    word[fromEnd] = tempChar;
                    fromStart++;
                    fromEnd--;
                }
            }

            // Answere
            ForegroundColor = ConsoleColor.Green;
            foreach (var item in word)
            {
                Write(item.Value);
                result += item.Value;
            }
            ForegroundColor = ConsoleColor.Gray;
            Write(" ");
            return result;
        }
    }
}
/*         




        
 */         