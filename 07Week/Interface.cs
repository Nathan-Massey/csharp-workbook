using System;

public class Program
{
    public static void Main()
    {
        Home myhome;
        ContractorA contractorA = new ContractorA();
        ContractorB contractorB = new ContractorB();

        int estimatedCA = contractorA.Estimated();
        int estimatedCB = contractorB.Estimated();

        Console.WriteLine($"ContractorA is charging ${estimatedCA}");
        Console.WriteLine($"ContractorB is charging ${estimatedCB}");

        if (estimatedCA < estimatedCB)
        {

            myhome = new Home(contractorA);
        }
        else
        {
            myhome = new Home(contractorB);
        }

        myhome.StartRenovation();

        Console.WriteLine($"The contractor that will renovate the house is {myhome.WhoGotHired()}");
        Console.WriteLine($"The Kitchen will be done on {myhome.Kitchen}");
        Console.WriteLine($"The Bathroom will be done on {myhome.Bathroom}");
        Console.WriteLine($"The Bedroom will be done on {myhome.Bedroom}");

        Console.ReadLine();
    }
}

// Contract in the form of Interface
// This is what the client wants but does not care how it's done

public interface IContractRenovation
{
    DateTime RenovateKitchen();
    DateTime RenovateBathroom(string color);
    DateTime RenovateBedroon(string color, string floor);
    int Estimated();
}

public class ContractorA : IContractRenovation
{
    public int Estimated()
    {
        Random randomEstimated = new Random();

        return randomEstimated.Next(100, 10000);
    }

    public DateTime RenovateBathroom(string color)
    {
        // How the bathroom is renovated it's 
        // not important to the customer

        return DateTime.Now.AddDays(20);
    }

    public DateTime RenovateBedroon(string color, string floor)
    {
        // How the bedroom is renovated it's 
        // not important to the customer
        return DateTime.Now.AddDays(25);
    }

    public DateTime RenovateKitchen()
    {
        // How the kitchen is renovated it's 
        // not important to the customer
        return DateTime.Now.AddDays(10);
    }
}

public class ContractorB : IContractRenovation
{
    public int Estimated()
    {
        Random randomEstimated = new Random();

        return randomEstimated.Next(100, 5000);
    }

    public DateTime RenovateBathroom(string color)
    {
        // How the bathroom is renovated it's 
        // not important to the customer
        return DateTime.Now.AddDays(15);
    }

    public DateTime RenovateBedroon(string color, string floor)
    {
        // How the bedroom is renovated it's 
        // not important to the customer
        return DateTime.Now.AddDays(5);
    }

    public DateTime RenovateKitchen()
    {
        // How the kitchen is renovated it's 
        // not important to the customer

        return DateTime.Now.AddDays(9);
    }
}

public class Home
{
    // To start the renovation class Home has a dependency
    // on a contractor. Since we don't know who is going to
    // get hired 
    private IContractRenovation _contractorHired;
    public DateTime Kitchen { get; set; }
    public DateTime Bathroom { get; set; }
    public DateTime Bedroom { get; set; }

    public Home(IContractRenovation contractor)
    {
        _contractorHired = contractor;
    }

    public void StartRenovation()
    {
        Kitchen = _contractorHired.RenovateKitchen();
        Bathroom = _contractorHired.RenovateBathroom("red");
        Bedroom = _contractorHired.RenovateBedroon("blue", "tile");
    }

    public string WhoGotHired()
    {
        return _contractorHired.ToString();
    }
}
