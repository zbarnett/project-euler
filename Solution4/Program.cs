using System;

public class Program {
    static void Main ( string[] args ) {

        uint largestPalindrome = 0;

        for (uint num1 = 100; num1 < 1000; num1++) {
            for (uint num2 = 100; num2 < 1000; num2++) {
                uint product = num1 * num2;

                if (IsPalindrome(product) && product > largestPalindrome) {
                    largestPalindrome = product;
                }
            }
        }

        Console.WriteLine(largestPalindrome);
        Console.Read();
    }

    static bool IsPalindrome(long number) {
        string numberAsString = number.ToString();

        char[] charArray = numberAsString.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);

        return reversed.Equals(numberAsString);
    }
}