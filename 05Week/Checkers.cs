using System;
using System.Collections.Generic;
using System.Linq;
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

public class Checker
{
    public string Color  { get; set; }
    public int[] Position  { get; set; }
    public string Symbol { get; set; }
    
    // Constructor 
    public Checker(string color, int[] position)
    {
        Color = color;
        Position = position;

        // Use unicode that represents the symbol
        // when we print to the console
        Symbol = color == "white" ? "\u25cb" : "\u25cf"; 
    }
}

public class Board
{
    public string[][] Grid { get; set; }
    public List<Checker> Checkers { get; set; }

    // Variables

    // Position of white checkers
    int[][] whitePosition = new int[][]
    {
       new int[] { 0, 1 },
       new int[] { 0, 3 },
       new int[] { 0, 5 },
       new int[] { 0, 7 },
       new int[] { 1, 0 },
       new int[] { 1, 2 },
       new int[] { 1, 4 },
       new int[] { 1, 6 },
       new int[] { 2, 1 },
       new int[] { 2, 3 },
       new int[] { 2, 5 },
       new int[] { 2, 7 },
    };

    // Position of black checkers
    int[][] blackPosition = new int[][]
    {
       new int[] { 5, 0 },
       new int[] { 5, 2 },
       new int[] { 5, 4 },
       new int[] { 5, 6 },
       new int[] { 6, 1 },
       new int[] { 6, 3 },
       new int[] { 6, 5 },
       new int[] { 6, 7 },
       new int[] { 7, 0 },
       new int[] { 7, 2 },
       new int[] { 7, 4 },
       new int[] { 7, 6 },
    };
    public Board()
    {
        return;
    }
    
    public void CreateBoard()
    {
        // Board is 8x8
        Grid = new string[][]
        {
            new string[] {" ", " ", " ", " ", " ", " ", " ", " ", },
            new string[] {" ", " ", " ", " ", " ", " ", " ", " ", },
            new string[] {" ", " ", " ", " ", " ", " ", " ", " ", },
            new string[] {" ", " ", " ", " ", " ", " ", " ", " ", },
            new string[] {" ", " ", " ", " ", " ", " ", " ", " ", },
            new string[] {" ", " ", " ", " ", " ", " ", " ", " ", },
            new string[] {" ", " ", " ", " ", " ", " ", " ", " ", },
            new string[] {" ", " ", " ", " ", " ", " ", " ", " ", },
        };
            
    }
    
    public void GenerateCheckers()
    {
        // 12 per position
        Checkers = new List<Checker>();

        for(var i = 0; i < whitePosition.Length; i++)
        {
            Checker checker = new Checker("white", whitePosition[i]);
            Checkers.Add(checker);
        }

        for (var i = 0; i < blackPosition.Length; i++)
        {
            Checker checker = new Checker("black", blackPosition[i]);
            Checkers.Add(checker);
        }
    }


    public void PlaceCheckers()
    {
        // Checkers List (property) contains all 24 pieces

        foreach(var c in Checkers)
        {
            int[] position = c.Position; // ex: [0,2]

            Grid[position[0]][position[1]] = c.Symbol;
        }

    }
    public void DrawBoard()
    {
        Console.WriteLine("  0 1 2 3 4 5 6 7");

        for(var i = 0; i < Grid.Length; i++) // Row
        {
            string column = $"{i} "; // Show the row index

           for(var e = 0; e < Grid[i].Length; e++) // Column
           {
                column += $"{Grid[i][e]} ";
           }

            Console.WriteLine(column);
        }
    }
    
    public Checker SelectChecker(int row, int column)
    {
        return Checkers.Find(x => x.Position.SequenceEqual(new List<int> { row, column }));
    }
    
    public void RemoveChecker(int row, int column)
    {
        var c = SelectChecker(row, column);
        Checkers.Remove(c);
    }
    
    public bool CheckForWin()
    {
        return Checkers.All(x => x.Color == "white") || !Checkers.Exists(x => x.Color == "white");
    }
}

class Game
{
    public Game()
    {
        Board board = new Board();
        board.CreateBoard();
        board.GenerateCheckers();
        board.PlaceCheckers();

        do
        {
            board.DrawBoard();
            // Make moves
            Console.WriteLine("Move or remove?");
            string input = Console.ReadLine();
            Console.WriteLine("Pickup Row:");
            int row = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Pickup Column:");
            int column = Int32.Parse(Console.ReadLine());
            var c = board.SelectChecker(row, column);
            Console.WriteLine("Place row:");
            row = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Place column:");
            column = Int32.Parse(Console.ReadLine());
            c.Position = new int[] { row, column };
            

            if (input == "remove")
            {
                Console.WriteLine("Remove row:");
                row = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Remove column:");
                column = Int32.Parse(Console.ReadLine());
                board.RemoveChecker(row, column);

            }
            board.CreateBoard();
            board.PlaceCheckers();

        }
        while (!board.CheckForWin());

    }
}
