public class Program
{
    static bool PalindromePermutation(string input)
    {
        input = input.ToLower().Replace(" ", "");

        int oddCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];

            bool alreadyChecked = false;

            for (int k = 0; k < i; k++)
            {
                if (input[k] == currentChar)
                {
                    alreadyChecked = true;
                    break;
                }
            }

            if (alreadyChecked)
                continue;

            int count = 0;

            for (int j = 0; j < input.Length; j++)
            {
                if (input[j] == currentChar)
                {
                    count++;
                }
            }

            if (count % 2 == 1)
            {
                oddCount++;
            }
        }

        return oddCount <= 1;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(PalindromePermutation("Tact Coa"));
    }
}