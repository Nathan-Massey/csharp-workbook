using System;

public static class Program

{
    public static void Main()
    {
        // 1 
        NumbersDivisbleByThree();

        // 2
        AddUpUtilOk();

        // 3
        MultiplyingInput();

        // 4
        RandomNumberGuess();

        // 5
        CountTheNumbers();

        Console.ReadLine();
    }


    public static void NumbersDivisbleByThree()
    {
        var NumbersDivisibleByThreeCount = 0;

        for (var i = 1; i <= 100; i++)
        {
            if(i % 3 == 0)
            {
                NumbersDivisibleByThreeCount++;
            }
        }
        Console.WriteLine("Amount of numbers I found divisible by 3 in 100 :" + NumbersDivisibleByThreeCount);

    }

    private static void AddUpUtilOk()
    {
        bool ContinueAsking = true;

        int Sum = 0;

        while (ContinueAsking)
        {
            Console.WriteLine("Give me a number.");

            string input = Console.ReadLine();

            int toNumber;

            bool WasANumber = int.TryParse(input, out toNumber);

            if (WasANumber == true)
            {
                Sum = Sum + toNumber;
            }

            if (input == "ok")
            {
                ContinueAsking = false;
            }

        }

        Console.WriteLine("All the numbers added together is: " + Sum);

    }

    private static void MultiplyingInput()
    {
        Console.WriteLine("Give me a number to find the factorial of it");

        string input = Console.ReadLine();

        int number = int.Parse(input);

        var factorial = 1;

        for (var i = number; i >= 2; i--)
        {
            factorial = factorial * i;
        }

        Console.WriteLine("The factorial of the number is: " + factorial);
    }

    private static void RandomNumberGuess()
    {
        Console.WriteLine("Guess a number between 1 and 10: ");

        string input = Console.ReadLine();

        int number = int.Parse(input);

        Random random = new Random();

        int randomNumber = random.Next(0, 10);

        for (var i = number; number != randomNumber; /*Repeate 4 times */ ) ;
        {

            if (input = randomNumber)
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("You lost!");
            }
        }
    }

    private static void CountTheNumbers()
    {
        Console.WriteLine("Enter numbers seperated by a comma:");

        {
            bool ContinueAsking = true;

            while (ContinueAsking)
            {
                string input = Console.ReadLine();

                int toNumber;

                bool WasANumber = int.TryParse(input, out toNumber);

                if (WasANumber == true)
                {
                    Math.Max(toNumber);

                    ContinueAsking = true;
                }

                if (input == "ok")
                {
                    ContinueAsking = false;
                }

            }

            Console.WriteLine("The highest number found was " + Math.Max(input);

        }


    }
}