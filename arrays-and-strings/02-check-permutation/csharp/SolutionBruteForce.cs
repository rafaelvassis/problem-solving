// Initial brute-force solution.
//
// Compares character frequencies by repeatedly scanning both strings.
// This approach prioritizes simplicity over efficiency.
//
// Time complexity: O(n²)
// Space complexity: O(1)

using System;

public class SolutionBruteForce
{
    static bool CheckPermutation(string firstWord, string secondWord)
    {
        if (firstWord.Length != secondWord.Length)
            return false;

        for (int word1Index = 0; word1Index < firstWord.Length; word1Index++)
        {
            char currentChar = char.ToLower(firstWord[word1Index]);

            int countInWord1 = 0;
            int countInWord2 = 0;

            for (int word2Index = 0; word2Index < secondWord.Length; word2Index++)
            {
                if (currentChar == char.ToLower(secondWord[word2Index]))
                {
                    countInWord2++;
                }
            }

            for (int firstWordIndex = 0; firstWordIndex < firstWord.Length; firstWordIndex++)
            {
                if (currentChar == char.ToLower(firstWord[firstWordIndex]))
                {
                    countInWord1++;
                }
            }

            if (countInWord1 != countInWord2)
            {
                return false;
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(CheckPermutation("TomMarvoloRiddle", "IamLordVoldemort"));
        Console.WriteLine(CheckPermutation("1991", "9111"));
        Console.WriteLine(CheckPermutation("Tree", "three"));
        Console.WriteLine(CheckPermutation("AMOR", "roma"));
    }
}