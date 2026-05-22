// Dictionary-based solution.
//
// Stores character frequencies dynamically using a hash table,
// allowing efficient lookup without assuming a fixed character set.
//
// Time complexity: O(n)
// Space complexity: O(n)

using System;

class SolutionDictionary
{
    static bool CheckPermutation(string firstWord, string secondWord)
    {
        if (firstWord.Length != secondWord.Length)
            return false;

        Dictionary<char, int> cache = new Dictionary<char, int>();
        

        for (int i = 0; i < firstWord.Length; i++)
        {
            char currentKey = char.ToLower(firstWord[i]);

            if (cache.TryGetValue(currentKey, out int currentValue))
            {
                cache[currentKey] = currentValue + 1;
            }
            else
            {
                cache.Add(currentKey, 1);
            }
        }

        for (int i = 0; i < secondWord.Length; i++)
        {
            char currentKey = char.ToLower(secondWord[i]);
            
            if (cache.TryGetValue(currentKey, out int currentValue))
            {
                cache[currentKey] = currentValue - 1;

                if (cache[currentKey] < 0) return false;
            }
            else
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