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

            // First permutation:
            string temp = "2017";
            GetPermutation(temp.ToCharArray(), 0, temp.Length - 1);
            foreach (var item in allPermutations)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");

            // New permutations:
            allPermutations.Clear();
            temp = "513";
            GetPermutation(temp.ToCharArray(), 0, temp.Length - 1);
            foreach (var item in allPermutations)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");
        }

        // Global helping variable
        public static List<string> allPermutations = new List<string>();

        // Actual perm
        private static void GetPermutation(char[] inputArray, int helper, int arrayLength)
        {
            if (helper == arrayLength)
            {
                if(!allPermutations.Contains(new string(inputArray)))
                    allPermutations.Add(new string(inputArray));
            }
            else
            {
                for (int ctr = helper; ctr <= arrayLength; ctr++)
                {
                    var temp = inputArray[helper];
                    inputArray[helper] = inputArray[ctr];
                    inputArray[ctr] = temp;
                    GetPermutation(inputArray, helper + 1, arrayLength);
                }
            }
        }
    }
}