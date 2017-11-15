using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
        // Instance of Stack Class
        Stack myStack = new Stack();

        try
        {
            myStack.Push("Nathan");
            myStack.Push(1234);
            myStack.Push(DateTime.Now);
            myStack.Push(true);
            myStack.Push(null);
        }
        catch(InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }

        Console.WriteLine(myStack.Pop()); // True
        Console.WriteLine(myStack.Pop()); // Time
        Console.WriteLine(myStack.Pop()); // Numbers
        Console.WriteLine(myStack.Pop()); // Name
        Console.WriteLine(myStack.Pop()); // Exception

        Console.ReadLine();
    }
}

public class Stack
{
    // Properties
    List<object> Lifo { get; set; }

    // Constructor
    public Stack()
    {
        Lifo = new List<object>();
    }

    // Methods

    // Push
    public void Push(object obj)
    {
        // Check if the obj is null and throw an exception

        Lifo.Add(obj);
        
        if(obj == null)
        {
            throw new InvalidOperationException("Trying to add 'null' value into the list, which is not possible.");
        }
    }

    // Pop
    public object Pop()
    {
        // Check if Lifo is empty and throw an exception

        if (Lifo.Count == 0)
        {
            throw new InvalidOperationException("There is no more objects in the Lifo list.");
        }

        int indexOfLast = Lifo.Count - 1; // Zero based index

        object cloned = Lifo[indexOfLast]; // ?

        Lifo.RemoveAt(indexOfLast);

        return cloned;
    }

    // Clear -- Remove all elements from the list
    public void Clear()
    {
        Lifo.Clear();
    }
}