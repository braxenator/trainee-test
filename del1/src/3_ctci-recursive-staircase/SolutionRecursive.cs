using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    //Denna funktion räknar ut hur många sätt
    //Davis kan klättra i trappan på, beroende 
    //på n antal trappsteg.
    public static int calcNum(int n, int[] array)
    {
        //De tre första trappstegen är enkla
        //att lösa med tre if-satser.
        if (n == 1)
        {
            return 1;
        }
        else if (n == 2)
        {
            return 2;
        }
        else if (n == 3)
        {
            return 4;
        }
        //Här sker rekursionen där funktionen kallar på
        //sig själv.
        else if (array[n - 1] == 0)
        {
            array[n - 1] = calcNum(n - 1, array) + calcNum(n - 2, array) + calcNum(n - 3, array);
        }
        return array[n - 1];
    }

    static void Main(String[] args)
    {
        int s = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < s; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n + 1];
            Console.WriteLine(calcNum(n, array));
        }
    }
}
