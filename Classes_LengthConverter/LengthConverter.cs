using System;

public class LengthConverter
{
	// Property
	public double Length { get; set; }

	// Constructor
	public LengthConverter(double aLength)
	{
		Length = aLength;
	}

	// Methods
	public double ToCentimeter()
	{
		double centimeter = Length * 100;
		return centimeter;
	}

	public double ToDecimeter()
	{
		double decimeter = Length * 10;
		return decimeter;
	}

	public double ToKilometer()
	{
		double kilometer = Length / 1000;
		return kilometer;
	}

	public double ToInch()
	{
		double inch = Length * 39.37008;
		return inch;
	}

	public double ToFoot()
	{
		double foot = Length * 3.28084;
        return foot;
    }

	public double ToYard()
	{
        double yard = Length * 1.093613;
        return yard;
    }
}
