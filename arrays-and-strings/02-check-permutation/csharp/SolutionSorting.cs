// Sorting-based solution.
//
// If two strings are permutations of each other,
// their sorted representations will be identical.
//
// Time complexity: O(n log n)
// Space complexity: O(n)

using System;
using System.Linq;

class SolutionSorting
{
    static bool CheckPermutation(string firstWord, string secondWord)
    {
        if (firstWord.Length != secondWord.Length)
            return false;

        string firstWordSorted = string.Concat(firstWord.ToLower().OrderBy(c => c));
        string secondWordSorted = string.Concat(secondWord.ToLower().OrderBy(c => c));

        return firstWordSorted == secondWordSorted;
    }
    


    static void Main(string[] args)
    {
        Console.WriteLine(CheckPermutation("TomMarvoloRiddle", "IamLordVoldemort"));
        Console.WriteLine(CheckPermutation("1991", "9111"));
        Console.WriteLine(CheckPermutation("Tree", "three"));
        Console.WriteLine(CheckPermutation("AMOR", "roma"));
    }
    
}