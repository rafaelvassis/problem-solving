using System;

public class Program
{
    static bool IsUnique(string text)
    {
        bool unique = true;

        for (int i = 0; i < text.Length; i++)
            {
                for (int j = i + 1; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                    {
                        unique = false;
                        break;
                    }
                }

                if (!unique) break;
            }

        return unique;
    }

    static void Main(string[] args)
    {
        Console.Write(IsUnique("LoremIpsum"));
    }
}