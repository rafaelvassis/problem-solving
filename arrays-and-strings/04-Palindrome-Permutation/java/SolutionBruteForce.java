public class SolutionBruteForce {

    public static boolean palindromePermutation(String input) {
        input = input.toLowerCase().replace(" ", "");

        int oddCount = 0;

        for (int i = 0; i < input.length(); i++) {
            char currentChar = input.charAt(i);

            boolean alreadyChecked = false;

            for (int k = 0; k < i; k++) {
                if (input.charAt(k) == currentChar) {
                    alreadyChecked = true;
                    break;
                }
            }

            if (alreadyChecked)
                continue;

            int count = 0;

            for (int j = 0; j < input.length(); j++) {
                if (input.charAt(j) == currentChar) {
                    count++;
                }
            }

            if (count % 2 != 0) {
                oddCount++;
                if (oddCount > 1)
                    return false;
            }
        }

        return true;
    }

    public static void main(String[] args) {
        System.out.println(palindromePermutation("tact coa")); // true: "taco cat"
    }
}