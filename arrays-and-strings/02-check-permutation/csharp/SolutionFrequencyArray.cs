// Frequency array solution.
//
// Performs case-insensitive comparison by normalizing
// all characters to lowercase.
//
// Uses a fixed-size frequency array assuming ASCII characters,
// allowing direct indexing and constant-time access.
//
// Time complexity: O(n)
// Space complexity: O(1)

using System;

class SolutionFrequencyArray
{
    static bool CheckPermutation(string firstWord, string secondWord)
    {
        if (firstWord.Length != secondWord.Length)
            return false;

        int[] frequency = new int[256];
        

        for (int i = 0; i < firstWord.Length; i++)
        {
            char currentChar = char.ToLower(firstWord[i]);
            frequency[currentChar]++;
        }

        for (int i = 0; i < secondWord.Length; i++)
        {
            char currentChar = char.ToLower(secondWord[i]);
            frequency[currentChar]--;
            if (frequency[currentChar] < 0) return false;
        }

        foreach(int i in frequency)
        {
            if (i != 0) return false;
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