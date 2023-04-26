using System;

public class Trip
{
	public string Location { get; set; }
	public double Distance { get; set; }
	public double FuelCost { get; set; }
}

public class FuelConsumption
{
    // Properties
    public string Location { get; set; }
    public double Distance { get; set; }

	// Constructor
	public FuelConsumption( string aLocation, double aDistance)
	{
		Location = aLocation;
		Distance = aDistance;
	}

	// Methods
	public static List<Trip> Trips 
	{
		List<Trip> TripsList = new List<Trip>();
	} 
	 
}
