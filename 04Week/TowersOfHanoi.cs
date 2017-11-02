using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static Dictionary<string, List<int>> stacks = new Dictionary<string, List<int>>()
    {
        { "a", new List<int>() {4, 3, 2, 1} },
        { "b", new List<int>() {} },
        { "c", new List<int>() {} }
    };
    
    public static void Main()
    {
        // Loop through the methods using do {...} while()
        // Think when the loop will end
        // Think of what methods calls go inside the code block


        do
        {
            PrintStacks();
            // Ask for start input
            Console.WriteLine("Enter pillar to move.");

            // Capture that input
            var start = Console.ReadLine();

            // Ask for finish input
            Console.WriteLine("Enter pillar to land.");

            // Capture that input
            var finish = Console.ReadLine();

            // Check if the move is legal
            IsLegal(start, finish);

            // We only make a move if the move was legal
            MovePiece(start, finish);

        }
        while (!CheckForWin());

        Console.ReadLine();

    }

    public static string ParseInputForStart(string input)
    {
        return string.Empty;
    }

    public static string ParseInputForFinish(string input)
    {
        return string.Empty;
    }

    public static bool CheckForWin()
    {
        // 3 - Check for win

        // We need to count the elements on
        // the "c" pillar

        if (stacks["c"].Count == 4)
            return true;

        return false;
    }
    
    public static void MovePiece (string start, string finish)
    {
        // 1 - Move a piece
        // Start will tell me which dictionary to grab
        // I know that the list has to return the top value

        int lastElement = stacks[start].Last();

        // Add lastElement into the finish pillar

        stacks[finish].Add(lastElement);

        // Remove it from start pillar

        stacks[start].Remove(lastElement);

    }
    
    public static bool IsLegal(string start, string finish)
    {
        // 2 - Check for legal move
        // Check for empty pillar - finish (List)
        if (stacks[finish].Count == 0)
            return true;

        // Check for existing values on both pillars
        int lastNumberFromStart = stacks[start].Last();
        int lastNumberFromFinish = stacks[finish].Last();

        if (lastNumberFromStart < lastNumberFromFinish)
            return true;

        return false;
    }
    
    public static void PrintStacks ()
    {
        string[] letters = new string[] {"a", "b", "c"};
        for( var i = 0; i < letters.Length; i++ )
        {
            List<string> blocks = new List<string>();
            for( var j = 0; j < stacks[letters[i]].Count; j++ )
            {
                blocks.Add(stacks[letters[i]][j].ToString());
            }
            Console.WriteLine(letters[i] + ": " + String.Join("|", blocks));	
        }
    }
}
