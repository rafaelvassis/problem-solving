import java.util.HashSet;

public class SolutionHashSet {

    static boolean isUnique(String text) {
        HashSet<Character> characters = new HashSet<>();

        for (char c : text.toCharArray()) {
            if (!characters.add(c)) {
                return false;
            }
        }

        return true;
    }

    public static void main(String[] args) {
        System.out.println(isUnique("LoremIpsum"));
    }
}