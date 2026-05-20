using System;
using System.Collections.Generic;

public class Program
{
    static bool IsUnique(string text)
    {
        HashSet<char> characters = new();

        foreach (char c in text)
        {
            if (!characters.Add(c))
            {
                return false;
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(IsUnique("LoremIpsu"));
    }
}