using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
        List<Person> people = new List<Person>()
        {
            new Person () { FirstName = "Nathan", LastName="Massey", BirthDate = DateTime.Now.AddYears(-28)},
            new Person () { FirstName = "Collin", LastName="Massey", BirthDate = DateTime.Now.AddYears(-24)},
            new Person () { FirstName = "Andrew", LastName="Luck", BirthDate = Convert.ToDateTime("6/12/1980")},
            new Person () { FirstName = "Kawhi", LastName="Leonard", BirthDate = Convert.ToDateTime("9/24/1982")},
        };

        //List<Person> peopleWithN = new List<Person>();

        //foreach(var p in people )
        //{
        //    if(p.FirstName[0] == 'N')
        //    {
        //        peopleWithN.Add(p);
        //    }
        //}

        // Queries
        var peopleYounger30 = from p in people
                          where p.Age() < 30
                          orderby p.LastName descending
                          select $"{p.FirstName} {p.LastName}";

        // Methods
        var peopleOlder30 = people
            .Where(p => p.Age() > 30)
            .OrderByDescending(p => p.LastName)
            .Select(p => $"{p.FirstName} {p.LastName}");

        foreach(var p in peopleOlder30)
        {
            Console.WriteLine(p);
        }

        Console.ReadLine();
	}
}

public class Person
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    // Method
    public int Age()
    {
        int todaysYear = DateTime.Today.Year; // 2017
        int personYear = BirthDate.Year;

        return todaysYear - personYear;
    }
}