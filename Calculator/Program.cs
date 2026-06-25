using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Basic Calculator");

        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Addition: {Add(a, b)}");
        Console.WriteLine($"Subtraction: {Subtract(a, b)}");
        Console.WriteLine($"Multiplication: {Multiply(a, b)}");
        Console.WriteLine($"Division: {Divide(a, b)}");


        Console.ReadKey();
    }

    public static double Add(double a, double b)
    {
        return a+b;
    }


    public static double Subtract(double a, double b)
    {
        return 0;
    }


    public static double Multiply(double a, double b)
    {
        return 0;
    }


    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            return 0; 
        }

        return a/b;
    }

}
