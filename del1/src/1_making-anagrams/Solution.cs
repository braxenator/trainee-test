using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int makingAnagrams(string s1, string s2)
    {
        //Ett HashSet för att samla alla unika bokstäver.       
        HashSet<char> hashset = new HashSet<char>();
        //Två Dictionaries för att tilldela varje bokstav en räknare.
        Dictionary<char, int> stringDic = new Dictionary<char, int>();
        Dictionary<char, int> stringDic2 = new Dictionary<char, int>();

        //Variabel för output.
        int result = 0;

        //Två foreach-loopar för att lägga in alla bokstäver
        //i HashSettet.
        foreach (char c in s1)
        {
            hashset.Add(c);
        }
        foreach (char c in s2)
        {
            hashset.Add(c);
        }

        //Här läggs alla bokstäver in i de två Dictionaries.
        foreach (char c in hashset)
        {
            stringDic.Add(c, 0);
            stringDic2.Add(c, 0);
        }

        //Här ökar räknaren ett steg för varje förekommande
        //bokstav i de två strängarna.
        foreach (char c in s1)
        {
            stringDic[c]++;
        }
        foreach (char c in s2)
        {
            stringDic2[c]++;
        }

        //Slutligen räknas den absoluta differensen ut genom
        //att gå igenom alla unika bokstäver i HashSettet och
        //sedan subtrahera de två Dictionaries.
        foreach (char c in hashset)
        {
            result += Math.Abs(stringDic[c] - stringDic2[c]);
        }
        return result;
    }

    static void Main(String[] args)
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        int result = makingAnagrams(s1, s2);
        Console.WriteLine(result);

        Console.ReadLine();
    }
}