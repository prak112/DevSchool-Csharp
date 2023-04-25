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
    public long TotalNumbers { get; set; }

    // class constructor
    public FibonacciNumbers(long aTotalNumbers)
    {
        TotalNumbers = aTotalNumbers;
    }

    // class Methods
    public List<long> ForwardSeries ()
    {
        // create result List
        List<long> forwardSeries = new List<long> { 0, 1};

        // add sum of (n-2)th and (n-1)th element
        for(int i = forwardSeries.Count; i <= TotalNumbers; i++)
        {
            long previous1 = forwardSeries[i - 1];
            long previous2 = forwardSeries[i - 2];
            long nextFib = previous1 + previous2;

            forwardSeries.Add(nextFib);
        }
        return forwardSeries;

    }

    public List<long> BackwardSeries ()
    {
        // create result List
        List<long> backwardSeries = new List<long> { 0, -1 };

        // add sum of (n)th and (n-1)th element
        for (int i = backwardSeries.Count; i <= TotalNumbers; i++)
        {
            long previous1 = backwardSeries[i - 1];
            long previous2 = backwardSeries[i - 2];
            long prevFib = previous1 + previous2;

            backwardSeries.Add(prevFib);
        }
        return backwardSeries;
    } 
}
