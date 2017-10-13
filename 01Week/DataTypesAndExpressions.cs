using System;

public class Program
{
	public static void Main()
	{
        Console.WriteLine("What's the first number?");

        int firstNumber;

        var didItParse = int.TryParse(Console.ReadLine(), out firstNumber);

        if(!didItParse)
        {
            firstNumber = 0;
        }

        Console.WriteLine("What's the second number?");

        int secondNumber;

        var didItParseAgain = int.TryParse(Console.ReadLine(), out secondNumber);

        if (!didItParseAgain)
        {
            secondNumber = 0;
        }

        int result = firstNumber + secondNumber;

        Console.WriteLine("The result is: " + result);
        Console.ReadLine();

        Console.WriteLine("Type a number in yards to convert it to inches:");

        int inches = int.Parse(Console.ReadLine()) * 36;

        Console.WriteLine(inches);
        Console.ReadLine();

        var people = true;

        var f = false;

        decimal num = 2.1m;

        Console.WriteLine(num * num);

        int convert = int.Parse(Console.ReadLine());
	}
}
