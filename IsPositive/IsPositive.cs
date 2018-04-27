using System;

using static IsNegative;

public class IsPositive
{
    public static bool Check(long number)
    {
        return !IsNegative.Check(number) && !IsZero.Check(number);
    }

    public static bool Check(double number)
    {
        return !IsNegative.Check(number) && !IsZero.Check(number);
    }

    public static bool Check(decimal number)
    {
        return !IsNegative.Check(number) && !IsZero.Check(number);
    }
}