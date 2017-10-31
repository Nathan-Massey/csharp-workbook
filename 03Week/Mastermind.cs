using System;

public class Program
{
    // possible letters in code
    public static char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
    
    // size of code
    public static int codeSize = 4;
    
    // number of allowed attempts to crack the code
    public static int allowedAttempts = 10;
    
    // number of tried guesses
    public static int numTry = 0;
    
    // test solution
    public static char[] solution = new char[] {'a', 'b', 'c', 'd'};
    
    // game board
    public static string[][] board = new string[allowedAttempts][];
    
    
    public static void Main()
    {
        CreateBoard();
        DrawBoard();
        char[] guess = new char[4];
        Console.WriteLine("Enter Guess:");
        guess = Console.ReadLine().ToCharArray();
        return;        
    }
    
    public static bool CheckSolution(char[] guess)
    {
        // Birng together into a single string

        // Guess
        string guessString = String.Join("", guess);

        // Solution
        string solutionString = String.Join(string.Empty, solution);

        if (guess == solution)
        {
            return true;
        }
        return false;
    }
    
    public static string GenerateHint(char[] guess)
    {
        // Clone solution
        char[] clonedSolution = (char[])solution.Clone();

        // Determine correct "letter-locations"
        int correctLetterLocation = 0;

        // Interate over cloneSolution
        for (var i = 0; i < clonedSolution.Length; i++)
        {
            // Compare cloneSolution against guess
            // For each index
            if (clonedSolution[i] == guess[i])
            {
                correctLetterLocation++;
                clonedSolution[i] = ' ';
            }
        }

        int correctLetters = 0;

        for (var i = 0; i < clonedSolution.Length; i++)
        {
            // Check if any letter inside the guess is found in the solution (cloned)
            char character = guess[i];
            string clonedSolutionString = String.Join("", clonedSolution);

            clonedSolutionString.IndexOf(character);
            // What value index gets when there is NO match
            char wrongCharacter =! guess[i];
            string clonedWrongString = String.Join("0", clonedWrongString);


            // What value index gets when there IS a match
            char correctCharacter = guess[i];
            string clonedCorrectString = String.Join("1", clonedCorrectSolution);

            // If you found the character - if(index ?)
            if(index correctCharacter);
                 {
                 // Increase correctLetter
                 correctLetter++;
                 // Remove the character from conedSolution
                 string.Remove conedSolution[i];
                 }
        }
       
        // Return the hint
    public static void ReturnHint(char[] guess)
    {
        // Combination of the correctLetterLocation and correctLetter
        for (var correctLetterLocation = clonedSolution)
        {
            // Hyphenated -  
            return Console.WriteLine(guess[i]++, "-", guess[i]++);
        }
    }
    
    public static void InsertCode(char[] guess)
    {
        return;
    }
    
    public static void CreateBoard()
    {
        for (var i = 0; i < allowedAttempts; i++)
        {
            board[i] = new string[codeSize + 1];
            for (var j = 0; j < codeSize + 1; j++)
            {
                board[i][j] = " ";
            }
        }
        return;
    }
    
    public static void DrawBoard()
    {
        for (var i = 0; i < board.Length; i++)
        {
            Console.WriteLine("|" + String.Join("|", board[i]));
        }
        
        return;
    }
    
    public static void GenerateRandomCode() {
        Random rnd = new Random();
        for(var i = 0; i < codeSize; i++)
        {
            solution[i] = letters[rnd.Next(0, letters.Length)];
        }
        return;
    }
}
