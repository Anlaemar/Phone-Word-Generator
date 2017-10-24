using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone
{
    class Program
    {
        static int[] number = new int[7];
        // Jagged array that holds multiple arrays for all letter
        static char[][] allLetters =
        {
                new char[] {'A', 'B', 'C'},
                new char[] {'D', 'E', 'F'},
                new char[] {'G', 'H', 'I'},
                new char[] {'J', 'K', 'L'},
                new char[] {'M', 'N', 'O'},
                new char[] {'P', 'Q', 'R', 'S'},
                new char[] {'T', 'U', 'V'},
                new char[] {'W', 'X', 'Y', 'Z'}
        };
        // This is the array of letters available from the 7-digit number user enters
        static char[][] letters = new char[7][];

        static void Main(string[] args)
        {
            GetInput();
            GetLettersVariations();
        }

        // Get number from user. This will correspond with indexes in letters array
        public static void GetInput()
        {
            Console.Write("Enter 7 digit number (do not use 0 or 1): ");
            string number = Console.ReadLine();

            for (int i = 0; i < 7; i++)
            {
                int index = Convert.ToInt32(number.Substring(i, 1)) - 2; // Our dial starts from 2 (0 and 1 are not used) - Basically converting # to index
                letters[i] = allLetters[index];
            }
        }

        public static void GetLettersVariations()
        {
            string word = "";

        }

        //Added for test
    }
}
