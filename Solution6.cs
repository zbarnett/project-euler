using System;

public class Program {
    static void Main ( string[] args ) {

        uint number = 100;

        uint sumOfSquares = SumOfSquares(number);
        uint squareOfSum = SquareOfSum(number);

        Console.WriteLine(squareOfSum - sumOfSquares);
        Console.Read();
    }

    static uint SumOfSquares(uint upperLimit) { 
        uint sum = 0;

        for (uint i = 1; i <= upperLimit; i++) {
            sum += i * i;
        }

        return sum;
    }

    static uint SquareOfSum(uint upperLimit)
    {
        uint sum = upperLimit * (upperLimit + 1) / 2;

        return sum * sum;
    }
}