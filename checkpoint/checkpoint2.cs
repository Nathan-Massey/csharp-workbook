using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Game game = new Game();

        Console.ReadLine();
    }
} 
public class Marker
{
    private static string playerTurn;

    public static void GetInput()
    {
        Console.WriteLine("Player " + playerTurn);
        Console.WriteLine("Enter Row:");
        int row = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter Column:");
        int column = Int32.Parse(Console.ReadLine());

        PlaceMark(row, column);
    }

    private static void PlaceMark(int row, int column)
    {
        throw new NotImplementedException();
    }
}

public class Board
{
    public static string playerTurn = "X";
    public static string[][] board = new string[][]
    {
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "}
    };

    public static void DrawBoard()
    {
        Console.WriteLine("  0 1 2");
        Console.WriteLine("0 " + String.Join("|", board[0]));
        Console.WriteLine("  -----");
        Console.WriteLine("1 " + String.Join("|", board[1]));
        Console.WriteLine("  -----");
        Console.WriteLine("2 " + String.Join("|", board[2]));
    }

    public static void PlaceMark(int row, int column)
    {
        board[row][column] = playerTurn;
    }
}

public class Game
{
    private string playerTurn;

    public Game()
    {
        Board board = new Board();
        

        bool CheckForWin()
        {
            bool hasPlayerWon = HorizontalWin() || VerticalWin() || DiagonalWin();

            if (hasPlayerWon)
            {
                Console.WriteLine("You Won!!");
            }
            else
            {
                playerTurn = playerTurn == "X" ? "O" : "X";
            }

            return hasPlayerWon;
        }

        bool HorizontalWin()
        {
            bool horizontalWin = false;

            if (Board.board[0][0] == playerTurn && Board.board[0][1] == playerTurn && Board.board[0][2] == playerTurn)
            {
                horizontalWin = true;
            }

            if (Board.board[1][0] == playerTurn && Board.board[1][1] == playerTurn && Board.board[1][2] == playerTurn)
            {
                horizontalWin = true;
            }

            if (Board.board[2][0] == playerTurn && Board.board[2][1] == playerTurn && Board.board[2][2] == playerTurn)
            {
                horizontalWin = true;
            }

            return horizontalWin;
        }

        bool DiagonalWin()
        {
            bool diagonalWin = false;

            if (Board.board[0][0] == playerTurn && Board.board[1][1] == playerTurn && Board.board[2][2] == playerTurn)
            {
                diagonalWin = true;
            }

            if (Board.board[2][0] == playerTurn && Board.board[1][1] == playerTurn && Board.board[0][2] == playerTurn)
            {
                diagonalWin = true;
            }

            return diagonalWin;
        }

        bool VerticalWin()
        {
            bool verticalWin = false;

            if (Board.board[0][0] == playerTurn && Board.board[1][0] == playerTurn && Board.board[2][0] == playerTurn)
            {
                verticalWin = true;
            }

            if (Board.board[0][1] == playerTurn && Board.board[1][1] == playerTurn && Board.board[2][1] == playerTurn)
            {
                verticalWin = true;
            }

            if (Board.board[0][2] == playerTurn && Board.board[1][2] == playerTurn && Board.board[2][2] == playerTurn)
            {
                verticalWin = true;
            }

            return verticalWin;
        }

        bool CheckForTie()
        {
            bool havePlayersTied = false;

            if (Board.board[0][0] != " " && Board.board[0][1] != " " && Board.board[0][2] != " " && Board.board[1][0] != " " && Board.board[1][1] != " "
                && Board.board[1][2] != " " && Board.board[2][0] != " " && Board.board[2][1] != " " && Board.board[2][2] != " ")
            {
                havePlayersTied = true;
            }

            return havePlayersTied;
        }
    }
       


}

