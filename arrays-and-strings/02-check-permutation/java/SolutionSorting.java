// Sorting-based solution.
//
// If two strings are permutations of each other,
// their sorted representations will be identical.
// Easier to reason about,
// but less efficient than frequency counting approaches.
//
// Time complexity: O(n log n)
// Space complexity: O(n)

import java.util.Arrays;

public class SolutionSorting {
    static boolean checkPermutation(String firstWord, String secondWord){

        char[] firstWordArray = firstWord.toLowerCase().toCharArray();
        char[] secondWordArray = secondWord.toLowerCase().toCharArray();

        Arrays.sort(firstWordArray);
        Arrays.sort(secondWordArray);

        String firstWordSorted = new String(firstWordArray);
        String secondWordSorted = new String(secondWordArray);

         
        return firstWordSorted.equals(secondWordSorted);
    }
    public static void main(String[] args){
     
        System.out.println(checkPermutation("TomMarvoloRiddle", "IamLordVoldemort"));
        System.out.println(checkPermutation("1991", "9111"));
        System.out.println(checkPermutation("Tree", "three"));
        System.out.println(checkPermutation("AMOR", "roma"));
    }

}
