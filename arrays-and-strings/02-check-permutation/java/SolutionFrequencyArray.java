// Frequency array solution.
//
// Performs case-insensitive comparison by normalizing
// all characters to lowercase.
//
// Uses a fixed-size frequency array assuming extended ASCII / byte range,
// allowing direct indexing and constant-time access.
//
// Time complexity: O(n)
// Space complexity: O(1)

public class SolutionFrequencyArray {

    static boolean checkPermutation(String firstWord, String secondWord){

        if (firstWord.length() != secondWord.length()) return false;

        int[] frequency = new int[256];

        for (int i = 0; i < firstWord.length(); i++){
            char currentChar = Character.toLowerCase(firstWord.charAt(i));

            frequency[currentChar]++;
        }

        for (int i = 0; i < secondWord.length(); i++){
            char currentChar = Character.toLowerCase(secondWord.charAt(i));

            frequency[currentChar]--;

            if (frequency[currentChar] < 0) return false;
        }

        return true;
    }

    public static void main(String[] args){
        System.out.println(checkPermutation("1991", "9111"));
        System.out.println(checkPermutation("TomMarvoloRiddle", "IamLordVoldemort"));
        System.out.println(checkPermutation("Tree", "three"));
        System.out.println(checkPermutation("AMOR", "roma"));
    }
    
}
