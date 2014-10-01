using System;

public class Program {
    static void Main ( string[] args ) {

        uint smallestDivisibleNum = 20;

        while (!IsEvenlyDivisible(smallestDivisibleNum))
            smallestDivisibleNum++;

        Console.WriteLine(smallestDivisibleNum);
        Console.Read();
    }

    static bool IsEvenlyDivisible( uint number ) {
        for (uint i = 20; i > 0; i--) {
            if (number % i != 0) {
                return false;
            }
        }

        return true;
    }
}