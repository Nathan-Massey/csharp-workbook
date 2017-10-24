using System;

public class Program
{
    public static string playerTurn = "X";
    public static string[][] board = new string[][]
    {
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "}
     };

    public static void Main()
    {
        do
        {
            DrawBoard();
            GetInput();
        }
        while (!CheckForWin());

        Console.ReadLine();
    }

    public static void GetInput()
    {
        Console.WriteLine("Player " + playerTurn);
        Console.WriteLine("Enter Row:");
        int row = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter Column:");
        int column = Int32.Parse(Console.ReadLine());
        PlaceMark(row, column);
        
        Console.WriteLine("Player turn: " + playerTurn);
        return;
    }

    public static void PlaceMark(int row, int column)
    {
        board[row][column] = playerTurn;
    }

    public static bool CheckForWin()
    {
        bool hasPlayerWon = HorizontalWin() || VerticalWin() || DiagonalWin();

        if (hasPlayerWon)
        {
            Console.WriteLine("Player " + playerTurn + " won!");
        }
        else
        {
            playerTurn = (playerTurn == "X") ? "O" : "X";
        }

        return hasPlayerWon;
        
    }

    public static bool HorizontalWin()
    {
        bool HorizontalWin = false;
        if (board[0][0] == playerTurn && board[0][1] == playerTurn && board[0][2] == playerTurn)
        {
            HorizontalWin = true;
        }
        if (board[1][0] == playerTurn && board[1][1] == playerTurn && board[1][2] == playerTurn)
        {
            HorizontalWin = true;
        }
        if (board[2][0] == playerTurn && board[2][1] == playerTurn && board[2][2] == playerTurn)
        {
            HorizontalWin = true;
        }

        return HorizontalWin;
    }

    public static bool VerticalWin()
    {
        bool VerticalWin = false;
        if (board[0][0] == playerTurn && board[1][0] == playerTurn && board[2][0] == playerTurn)
        {
            VerticalWin = true;
        }
        if (board[0][1] == playerTurn && board[1][1] == playerTurn && board[2][1] == playerTurn)
        {
            VerticalWin = true;
        }
        if (board[0][2] == playerTurn && board[1][2] == playerTurn && board[2][2] == playerTurn)
        {
            VerticalWin = true;
        }

        return VerticalWin;
    }

    public static bool DiagonalWin()
    {
        bool DiagonalWin = false;
        if (board[0][0] == playerTurn && board[1][1] == playerTurn && board[2][2] == playerTurn)
        {
            DiagonalWin = true;
        }
        if (board[2][0] == playerTurn && board[1][1] == playerTurn && board[0][2] == playerTurn)
        {
            DiagonalWin = true;
        }

        return DiagonalWin;
    }

    public static void DrawBoard()
    {
        Console.WriteLine("  0 1 2");
        Console.WriteLine("0 " + String.Join("|", board[0]));
        Console.WriteLine("  -----");
        Console.WriteLine("1 " + String.Join("|", board[1]));
        Console.WriteLine("  -----");
        Console.WriteLine("2 " + String.Join("|", board[2]));
        return;
    }

    public static bool CheckForTie()
    {
        bool tied = false;

        if(board[0][0] != " ")
        {
            tied = true;
        }

        return tied;

    }
}
