// In-place URLify solution using reverse traversal.
//
// Instead of repeatedly shifting characters,
// the algorithm fills the array backwards using
// the extra buffer space available at the end.
//
// Time complexity: O(n)
// Space complexity: O(1)

public class SolutionInPlace {
    
    static void URLify(char[] input, int trueLength){
     
        int writeIndex = input.length - 1;

        for (int i = trueLength - 1; i >=0; i--){
            
            if (input[i] != ' ') {
                input[writeIndex] = input[i];
                writeIndex--;
            }
            else {
                input[writeIndex] = '0';
                input[writeIndex - 1] = '2';
                input[writeIndex - 2] = '%';
                writeIndex -= 3;
            }

        }

        System.err.println(new String(input));
        
    }
    public static void main(String[] args){

        String input = "Mr John Smith    ";
        char[] chars = input.toCharArray();
        URLify(chars, 13);
    }
}
