using System;
using System.Linq;
using System.Collections.Generic;
// Given a string of words, you need to find the highest scoring word.
// Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.
// You need to return the highest scoring word as a string.
public class Kata
{
    public static string High(string s)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        List<string> array = new List<string>(s.Split());
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach(string str in array)
        {
            int summ = 0;
            foreach(Char t in str)
            {
                summ += (alphabet.IndexOf(t)+1);
            }
            if(!dict.ContainsKey(str))
                dict.Add(str, summ);
            else
            if(summ >= dict[str])
                dict[str] = summ;
        }
        return dict.Aggregate((x, y) => x.Value >= y.Value ? x : y).Key;
    }
}