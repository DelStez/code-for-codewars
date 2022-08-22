using System;
// Digital root is the recursive sum of all the digits in a number.
// Given n, take the sum of the digits of n.
// If that value has more than one digit,
// continue reducing in this way until a single-digit number is produced.
// The input will be a non-negative integer.
public class Number
{
    public int DigitalRoot(long n)
    {
        long summ = n;
        string numbers = Convert.ToString(summ);
        while(numbers.Length != 1)
        {
            numbers = Convert.ToString(summ);
            summ = 0;
            foreach(Char t in numbers)
                summ += Convert.ToInt64(Convert.ToString(t));
        }
        return (int)summ; 
    }
}