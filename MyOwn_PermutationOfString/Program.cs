using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwn_PermutationOfString
{
    class Program
    {
        static void Main()
        {
            // Origin of this project is codewars: https://www.codewars.com/kata/5254ca2719453dcc0b00027d/
            GetPermutation("2017", 0);
            allPermutations.ForEach(x => Console.WriteLine(x));
        }

        // Global helping variable
        public static List<string> allPermutations = new List<string>();

        /// <summary>
        /// Takes given string and permutates all options.
        /// </summary>
        /// <param name="inputString">String to be permutated.</param>
        /// <param name="helper">Helping variable.</param>
        private static void GetPermutation(string inputString, int helper)
        {
            char[] inputArray = inputString.ToCharArray();

            if (helper == inputString.Length)
            {
                if(!allPermutations.Contains(new string(inputArray)))
                    allPermutations.Add(new string(inputArray));
            }
            else
            {
                for (int ctr = helper; ctr < inputString.Length; ctr++)
                {
                    var temp = inputArray[helper];
                    inputArray[helper] = inputArray[ctr];
                    inputArray[ctr] = temp;
                    inputString = new string(inputArray);
                    GetPermutation(inputString, helper + 1);
                }
            }
        }
    }
}