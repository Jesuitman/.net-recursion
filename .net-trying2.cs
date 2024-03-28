using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        long factorial = CalculateFactorial(number);

        Console.WriteLine($"The factorial of {number} is {factorial}");
    }
    static long CalculateFactorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * CalculateFactorial(n - 1);
    }
}
