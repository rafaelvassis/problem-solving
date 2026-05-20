public class SolutionBruteForce {

    static boolean isUnique(String text) {
        boolean unique = true;

        for (int i = 0; i < text.length(); i++) {

            for (int j = i + 1; j < text.length(); j++) {

                if (text.charAt(i) == text.charAt(j)) {
                    unique = false;
                    break;
                }
            }

            if (!unique) {
                break;
            }
        }

        return unique;
    }

    public static void main(String[] args) {
        System.out.println(isUnique("LoremIpsum"));
    }
}