// In-place URLify solution using reverse traversal.
//
// Instead of shifting characters multiple times,
// the algorithm works backwards from the end of the true content.
//
// Extra spaces at the end of the array are used to expand
// each space character into "%20".
//
// Time complexity: O(n)
// Space complexity: O(1)

using System;

class SolutionInPlace
{
    static void URLify(char[] input, int trueLength)
    {
        int writeIndex = input.Length - 1;

        for (int i = trueLength - 1; i >= 0; i--)
        {
            if (input[i] != ' ')
            {
                input[writeIndex] = input[i];
                writeIndex--;
            }
            else
            {
                input[writeIndex] = '0';
                input[writeIndex - 1] = '2';
                input[writeIndex - 2] = '%';
                writeIndex -= 3;

            }
        }

        Console.WriteLine(new string(input));
    }

    public static void Main(string[] args)
    {
        string input = "Mr John Smith    ";
        char[] chars = input.ToCharArray();
        URLify(chars, 13);
    }
}