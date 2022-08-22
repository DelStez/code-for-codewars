using System;
using System.Linq;
using System.Text.RegularExpressions;
// An orderly trail of ants is marching across the park picnic area.
// It looks something like this:
// ..ant..ant.ant...ant.ant..ant.ant....ant..ant.ant.ant...ant..
// But suddenly there is a rumour that a dropped chicken sandwich has been spotted on the ground ahead. The ants surge forward! Oh No, it's an ant stampede!!
// Some of the slower ants are trampled, and their poor little ant bodies are broken up into scattered bits.
// The resulting carnage looks like this:
public class Kata
{
    public static int DeadAntCount(string ants)
    {
        int count = 0;
        if(ants != null)
        {
            string v = Regex.Replace(ants, @"(ant)", " ");
            int a = 0; int n = 0; int t = 0;
            foreach (Match match in Regex.Matches(v, @"[ant]", RegexOptions.IgnoreCase))
            {
                switch(match.Value)
                {
                    case "a":
                        a++;
                        break;
                    case "n":
                        n++;
                        break;
                    case "t":
                        t++;
                        break;
                } 
            }
            count = (new int[] {a, n, t}).Max();         
        }
        return count;
    }
}