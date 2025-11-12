package org.neko;

class Solution {
    public static String solve(String s) {
        String result = "";
        String tempChar = "";

        if (!Character.isDigit(s.charAt(0))) s = "1" + s; // add 1 digit if the first character is a letter
        s = s.replaceAll("[\\[\\]()]", ""); // Remove all brackets

        for (int i = s.length(); i > 0; i--) {
            char character = s.charAt(i - 1);
            if (!Character.isDigit(character)) tempChar = character + tempChar;

            else {
                tempChar = tempChar + result;
                result = "";
                for (int j = 0; j < Integer.parseInt(String.valueOf(character)); j++) {
                    result += tempChar;
                }
                tempChar = "";
            }
        }
        return result;
    }
}