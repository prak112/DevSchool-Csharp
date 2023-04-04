using System;

/// <summary>
/// logic for the working of a calculator
/// </summary>

class Calculator
{
    public static double DoOperation(double x, double y, string op)
    {
        double result = double.NaN; //output for division with 0, 'not-a-number'

        // switch statement for all arithmetic operations
        switch (op)
        {
            case "a":
                result = x + y; break;

            case "s":
                result = x - y; break;

            case "m":
                result = x * y; break;

            case "d":
                if (y != 0) result = x / y; 
                break;
            
            default:
                break;
        }
        return result;
    }
}