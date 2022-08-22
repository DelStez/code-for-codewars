using System;
using System.Linq;
// Given an array of integers, find the one that appears an odd number of times.
//
// There will always be only one integer that appears an odd number of times.
// namespace Solution
{
    class Kata
    {
        public static int find_it(int[] seq) 
        {
            return seq.ToList().Find(x => seq.Count(y=> y==x) % 2 !=0);
        }
    }
}