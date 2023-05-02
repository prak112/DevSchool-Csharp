using System;

// class to define data structures for Travel data - TripInput
public class TripInput
{
    public string Location { get; set; }
    public double Distance { get; set; }
}

// class to define data structures for Travel data - TripOutput
public class TripOutput
{
	public string Location { get; set; }
	public double Distance { get; set; }
	public double FuelCost { get; set; }
}


// calculate TripExpenses using TripInputList and return TripOutputList
public class FuelConsumption
{
    // Property - declare List with TripOutput class
    // reference source - https://www.dotnetstuffs.com/exposing-generic-list-as-property-of-class-in-c-sharp/
    public List<TripOutput> tripOutputList { get; set; }
	public double FuelCost { get; set; }
    public double FuelPrice;


    // Constructor
    public FuelConsumption(double aFuelCost, double aFuelPrice)
    {
        // construct TripsList
        tripOutputList = new List<TripOutput>();
        FuelCost = aFuelCost;
        FuelPrice = aFuelPrice;
    }

    // Methods
    public static List<TripOutput> TripExpenses (List<TripInput> tripInputList, double FuelPrice)
	{
        // initialize output list
        List<TripOutput> tripOutputList = new List<TripOutput>();

		// calculate fuel cost for each trip, add fuel expense
		foreach(var item in tripInputList)
		{
			// define data object for every item
			TripOutput data = new TripOutput();

			// store user input
			data.Location = item.Location;
			data.Distance = item.Distance;

            // calculate FuelCost, add to tripOutputList
            data.FuelCost = Math.Round(((item.Distance * FuelPrice) / 100d), 3);
            
            // add data object to TripsList
            tripOutputList.Add(data);
		}
		return tripOutputList;
	}

}
