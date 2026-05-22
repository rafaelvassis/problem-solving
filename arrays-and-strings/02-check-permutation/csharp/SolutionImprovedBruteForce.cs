// Improved brute-force solution.
//
// Reduces redundant frequency recalculations by tracking
// already processed characters.
//
// Although the overall time complexity remains O(n²),
// this version performs fewer unnecessary operations
// for repeated characters.

using System;

public class SolutionImprovedBruteForce
{
    static bool CheckPermutation(string firstWord, string secondWord)
    {
        if (firstWord.Length != secondWord.Length)
            return false;

        char[] processedCharacters = new char[firstWord.Length];
        int nextIndex = 0;

        for (int word1Index = 0; word1Index < firstWord.Length; word1Index++)
        {
            char currentChar = char.ToLower(firstWord[word1Index]);

            int countInWord1 = 0;
            int countInWord2 = 0;

            bool isInArray = false;

            for (int i = 0; i < processedCharacters.Length; i++)
            {
                if (processedCharacters[i] == currentChar)
                {
                    isInArray = true;
                    break;
                }
            }

            if (!isInArray)
            {

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
                else
                {
                    processedCharacters[nextIndex] = currentChar;
                    nextIndex++;
                }
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