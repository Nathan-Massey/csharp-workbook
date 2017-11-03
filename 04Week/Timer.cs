using System;
using System.Diagnostics;

public class Program
{

	public static void Main()
	{
        // Create a new instance of the class Timer
        Timer myTimer = new Timer();
        bool continueAsking = true;

        do
        {
            Console.WriteLine("What do you want to do?"); // 0 = Start, 1 = Stop, X = Exit

            var input = Console.ReadLine();

            if (input == "0")
            {
                // Try to catch

                try
                {
                    myTimer.Start();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Hey, timer has already started.");
                }

                myTimer.Start();
            }

            if (input == "1")
            {
                myTimer.Stop();
                Console.WriteLine($"The time was {myTimer.StopWatch.Elapsed}");
            }

            if (input == "x")
            {
                continueAsking = false;

            }

        } while (continueAsking);
	}
}

public class Timer
{
    // Define propertires
    public bool IsTimerWorking { get; set; }
    public Stopwatch StopWatch { get; set; }

    // Define methods - This is what the class does

    public void Start()
    {
        if (IsTimerWorking) // Already counting time
        {
            // WE have to prevent from starting again
            throw new InvalidOperationException();
        }
        else 
        {
            // Reset timer every time

            // Kick off the timer
            StopWatch = Stopwatch.StartNew();

            IsTimerWorking = true;
        }

    }

    public void Stop()
    {
        // Actually stop the watch

        StopWatch.Stop();

        // Toggle the flag back to false
        IsTimerWorking = false;
    }
}
