using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter hand 1:");
        string hand1 = Console.ReadLine().ToLower();
        Console.WriteLine("Enter hand 2:");
        string hand2 = Console.ReadLine().ToLower();
        Console.WriteLine(CompareHands(hand1, hand2));

        CompareHands(hand1, hand2);

        Console.ReadLine();
    }
    
    public static string CompareHands(string hand1, string hand2)
    {
        if (hand1 == hand2)
        {
            return "It's a tie!";
        }

        if (hand1 == "rock")
        {
            if (hand2 == "scissors")
            {
                return "Hand one wins!";
            }
            // If we reach here, player 2 must have dealt paper
            return "Hand two wins!";
        }

        if (hand1 == "paper")
        {
            // fill this in using the logic above
            if (hand2 == "rock")
            {
                return "Hand one wins!";
            }
            return "Hand two wins!";

        }

        if (hand1 == "scissors")
        {
            // fill this in using the logic above
            if (hand2 == "paper")
            {
                return "Hand one wins!";
            }
            return "Hand two wins!";

        }

        return hand1 + " " + hand2;
    }
}
