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

            for (int i1 = 0; i1 < letters[0].Length; i1++)
            {
                for (int i2 = 0; i2 < letters[1].Length; i2++)
                {
                    for (int i3 = 0; i3 < letters[2].Length; i3++)
                    {
                        for (int i4 = 0; i4 < letters[3].Length; i4++)
                        {
                            for (int i5 = 0; i5 < letters[4].Length; i5++)
                            {
                                for (int i6 = 0; i6 < letters[5].Length; i6++)
                                {
                                    for (int i7 = 0; i7 < letters[6].Length; i7++)
                                    {
                                        word = letters[0][i1].ToString();
                                        word += letters[1][i2].ToString();
                                        word += letters[2][i3].ToString();
                                        word += letters[3][i4].ToString();
                                        word += letters[4][i5].ToString();
                                        word += letters[5][i6].ToString();
                                        word += letters[6][i7].ToString();

                                        using (System.IO.StreamWriter file = new System.IO.StreamWriter("WriteLines.txt", true))
                                        {
                                            file.WriteLine(word);
                                        }
                                        word = "";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
