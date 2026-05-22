// Improved brute-force solution.
//
// Reduces redundant frequency recalculations by tracking
// already processed characters.
//
// Although the overall time complexity remains O(n²),
// this version performs fewer unnecessary operations
// for repeated characters.

public class SolutionImprovedBruteForce
{
    static boolean checkPermutation(String firstWord, String secondWord){
        if (firstWord.length() != secondWord.length()) return false;

        char[] processedCharacters = new char[firstWord.length()];

        int nextIndex = 0;
        
        for (int word1Index = 0; word1Index < firstWord.length(); word1Index++){
            
            char currentChar = Character.toLowerCase(firstWord.charAt(word1Index));
        
            int countInWord1 = 0;
            int countInWord2 = 0;

            boolean isInArray = false;

            for (int i = 0; i < processedCharacters.length; i++){

                if (currentChar == processedCharacters[i]){
                    
                    isInArray = true;
                    break;

                }
            }

            if (!isInArray){

                for (int word2Index = 0; word2Index < secondWord.length(); word2Index++){

                    if (currentChar == Character.toLowerCase((secondWord.charAt(word2Index)))){                        
                        countInWord2++;
                    }
                }

                for (int firstWordIndex = 0; firstWordIndex < firstWord.length(); firstWordIndex++){
                    if (currentChar == Character.toLowerCase(firstWord.charAt(firstWordIndex))){
                        countInWord1++;
                    }
                }
            }

            if (countInWord1 != countInWord2) {
                return false;
            } 
            else {
                processedCharacters[nextIndex] = currentChar;
                nextIndex++;
            }

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