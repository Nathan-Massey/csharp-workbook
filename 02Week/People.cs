using System;


public class Program
{
    public static void Main()
    {
        //Create a instance of a class
        var myPeople = new People();

        myPeople.Height = 100;
        myPeople.Name = "Nathan";
        myPeople.LastName = "Massey";

        myPeople.Greeting();

        Console.ReadLine();
        
    }
}

public class People
{
    //Properties
    public decimal Height { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }

    //Methods
    public void Greeting ()
    {
        Console.WriteLine("Hellow my name is " + Name + " " + LastName);
    }
}
