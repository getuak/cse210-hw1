
using System;
// creates a class that holds fraction the attributes are private.
public class Fraction
{
    private int _top;
    private int _bottom;
// Constractor with no parameter that intialize the number to 1/1
    public Fraction()

    {
        _top = 1;
        _bottom = 1;
    }
// constractor with one parameter for topand initialize the bottom
    public Fraction(int wholeNumber)


    {
         _top = wholeNumber;
         _bottom = 1;

    }
// constractor with two parameters one for the top and one for the bottom
    public Fraction(int top, int bottom)

    {
         _top = top;
        _bottom = bottom;
    }
// getter and setters for top and bottom and returns the values
    public string GetFractionString()
    {
        string value = ($"{_top}/{_bottom}");
        return value;
    }

    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
       
    }
}