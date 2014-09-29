using System;

public class Program {
    static void Main ( string[] args ) {

        uint sum = 0;

        uint smallFibTerm = 1;
        uint largeFibTerm = 2;

        while ( smallFibTerm < 4000000 ) {
            if (smallFibTerm % 2 == 0) {
                sum += smallFibTerm;
            }

            uint newFibTerm = smallFibTerm + largeFibTerm;

            // rotate
            smallFibTerm = largeFibTerm;
            largeFibTerm = newFibTerm;
        }

        Console.WriteLine(sum);
        Console.Read();
    }
}