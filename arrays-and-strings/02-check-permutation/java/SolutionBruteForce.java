// Initial brute-force solution.
//
// Compares character frequencies by repeatedly scanning both strings.
// This approach prioritizes simplicity over efficiency.
//
// Time complexity: O(n²)
// Space complexity: O(1)

public class SolutionBruteForce {

    static boolean checkPermutation(String firstWord, String secondWord) {

        if (firstWord.length() != secondWord.length()) {
            return false;
        }

        for (int word1Index = 0; word1Index < firstWord.length(); word1Index++) {

            char currentChar = Character.toLowerCase(firstWord.charAt(word1Index));

            int countInWord1 = 0;
            int countInWord2 = 0;

            for (int word2Index = 0; word2Index < secondWord.length(); word2Index++) {

                if (currentChar == Character.toLowerCase(secondWord.charAt(word2Index))) {
                    countInWord2++;
                }
            }

            for (int firstWordIndex = 0; firstWordIndex < firstWord.length(); firstWordIndex++) {

                if (currentChar == Character.toLowerCase(firstWord.charAt(firstWordIndex))) {
                    countInWord1++;
                }
            }

            if (countInWord1 != countInWord2) {
                return false;
            }
        }

        return true;
    }

    public static void main(String[] args) {

        System.out.println(checkPermutation("TomMarvoloRiddle", "IamLordVoldemort"));
        System.out.println(checkPermutation("1991", "9111"));
        System.out.println(checkPermutation("Tree", "three"));
        System.out.println(checkPermutation("AMOR", "roma"));

    }
}