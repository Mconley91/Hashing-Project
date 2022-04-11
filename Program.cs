using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (1 > 0)
            {
                Console.WriteLine("Enter a 6 letter word to be hashed.");
                string entry = Console.ReadLine();
                HashConverter(entry);
            }
        }
        public static string HashConverter(string entry)
        {
            string A = Convert.ToString(entry[0]);
            string B = Convert.ToString(entry[1]);
            string C = Convert.ToString(entry[2]);
            string D = Convert.ToString(entry[3]);
            string E = Convert.ToString(entry[4]);
            string F = Convert.ToString(entry[5]);

            string[] letters = {"a", "b", "c", "d", "e", "f", "g",
                "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", 
                "r", "s", "t", "u", "v", "w", "x", "y", "z"};

            //1st letter
            if (A == Convert.ToString(letters[0])) //STUCK HERE
            {
                A = Convert.ToString(letters[17]);
            }
            else
            {
                A = "177";
            }
            //2nd letter
            if (B == Convert.ToString(letters[0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10]))
            {
                B = Convert.ToString(letters[4]);
            }
            else
            {
                B = "232";
            }
            //3rd letter
            if (C == Convert.ToString(letters[0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10]))
            {
                C = Convert.ToString(letters[9]);
            }
            else
            {
                C = "471";
            }
            //4th letter
            if (D == Convert.ToString(letters[0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10]))
            {
                D = Convert.ToString(letters[7]);
            }
            else
            {
                D = "111";
            }
            //5th letter
            if (E == Convert.ToString(letters[0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10]))
            {
                E = Convert.ToString(letters[20]);
            }
            else
            {
                E = "567";
            }
            //6th letter
            if (F == Convert.ToString(letters[0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10]))
            {
                F = Convert.ToString(letters[0]);
            }
            else
            {
                F = "937";
            }
            string hashedValue = (F + E + D + C + B + A );
            Console.WriteLine(hashedValue);
            return hashedValue;
        }
    }
}
