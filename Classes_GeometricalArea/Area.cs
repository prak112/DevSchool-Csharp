using System;

public class Triangle
{
	// Class Properties
	public double Base { get; set; }
	public double Height { get; set; }

	// Class Constructor
	public Triangle(double aBase, double aHeight)
	{
		Base = aBase;
		Height = aHeight;
	}

	// Class Methods
	public double Area(double Base, double Height)
	{
		double area = 0.5 * Base * Height;
		return area;
	}

	public double Perimeter(double Base)
	{ 
		double perimeter = Base * 3;		// assuming Equilateral Triangle, all sides equal. Hence, (base * 3)
		return perimeter;
	}

}


public class Square
{
	// Class Properties
	public double Side { get; set; }
	
	// Class Constructor
	public Square (double aSide)
	{
		Side = aSide;
	}

	// Class Methods
	public double Area(double Side)
	{
		double area = Side * Side;
		return area;
	}

	public double Perimeter(double Side)
	{
		double perimeter = 4 * Side;
		return perimeter;
	}
}