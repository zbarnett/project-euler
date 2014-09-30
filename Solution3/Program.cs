using System;

public class Program {
    static void Main ( string[] args ) {

        long number = 600851475143;

        Console.WriteLine(LargestPrimeFactor(number));
        Console.Read();
    }

    static long LargestPrimeFactor( long number ) {

        long remainder = number;
        long largestPrime = 2;

        for ( long divisor = 2; divisor <= remainder; divisor++ ) {
            while ( remainder % divisor == 0 ) {
                largestPrime = divisor;
                remainder /= divisor;
            }
        }

        return largestPrime;
    }
}