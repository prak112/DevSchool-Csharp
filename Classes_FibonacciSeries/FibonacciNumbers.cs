using System;
using System.Collections.Generic;

// logic
// base elements 0 ,1
// FORWARD -> nth element = (n-1)th element + (n-2)th element
// BACKWARD -> (n-2)th element = (n-1)th + nth element

// class for Fibonacci logic
public class FibonacciNumbers
{
    // class properties
    public int TotalNumbers { get; set; }

    // class constructor
    public FibonacciNumbers(int aTotalNumbers)
    {
        TotalNumbers = aTotalNumbers;
    }

    // class Methods
    public List<int> ForwardSeries ()
    {
        // create result List
        List<int> forwardSeries = new List<int> { 0, 1};

        // add sum of (n-2)th and (n-1)th element
        for(int i = forwardSeries.Count; i <= TotalNumbers; i++)
        {
            int previous1 = forwardSeries[i - 1];
            int previous2 = forwardSeries[i - 2];
            int nextFib = previous1 + previous2;

            forwardSeries.Add(nextFib);
        }
        return forwardSeries;

    }

    public List<int> BackwardSeries ()
    {
        // create result List
        List<int> backwardSeries = new List<int> { -1, 0 };

        // add sum of (n)th and (n-1)th element
        for (int i = backwardSeries.Count; i <= TotalNumbers; i++)
        {
            int previous1 = backwardSeries[i - 1];
            int previous2 = backwardSeries[i - 2];
            int prevFib = previous1 + previous2;

            backwardSeries.Add(prevFib);
        }
        return backwardSeries;
    } 
}
