// HashMap-based solution.
//
// Stores character frequencies dynamically using a hash table,
// allowing efficient lookup without assuming a fixed character set.
//
// Time complexity: O(n)
// Space complexity: O(n)

import java.util.Map;
import java.util.HashMap;

public class SolutionHashMap {
    
    static boolean checkPermutation(String firstWord, String secondWord){

        if (firstWord.length() != secondWord.length()) return false;

        Map<Character, Integer> cache = new HashMap<>();

        for (int i = 0; i < firstWord.length(); i++){
            char currentChar = Character.toLowerCase(firstWord.charAt(i));

            cache.put(currentChar, cache.getOrDefault(currentChar, 0) + 1);
        }

        for (int i = 0; i < secondWord.length(); i++){
            char currentChar = Character.toLowerCase(secondWord.charAt(i));

            int updatedFrequency = cache.getOrDefault(currentChar, 0) - 1;

            cache.put(currentChar, updatedFrequency);

            if (updatedFrequency < 0) return false;
        }


        return true;
    }

    public static void main(String[] args){
     
        System.out.println(checkPermutation("TomMarvoloRiddle", "IamLordVoldemort"));
        System.out.println(checkPermutation("1991", "9111"));
        System.out.println(checkPermutation("Tree", "three"));
        System.out.println(checkPermutation("AMOR", "roma"));
    }

}
