using System;

// class to define data structure for FuelConsumption
public class Trip
{
	public string Location { get; set; }
	public double Distance { get; set; }
	public double FuelCost { get; set; }
}

public class FuelConsumption
{
    // Property - declare List with Trip class
	public List<Trip> Trips { get; set; }

	// Constructor
	public FuelConsumption()
	{
		// construct TripsList
		TripsList = new List<Trip>();
	}

	// Methods
	public static List<Trip> TripExpenses () 
	{
		// initialize output list
		List<Trip> TripsList = new List<Trip>();

		// calculate fuel cost for each trip, add fuel expense

	} 
	 
}
