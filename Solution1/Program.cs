using System;

public class Program {
    static void Main ( string[] args ) {

        uint sum = 0;

        for (uint i = 0; i < 1000; i++) {
            if (i % 3 == 0 || i % 5 == 0) {
                sum += i;
            }
        }

        Console.WriteLine(sum);
    }
}