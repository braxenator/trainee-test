using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    //Denna funktion räknar ut hur många sätt
    //Davis kan klättra i trappan på, beroende 
    //på n antal trappsteg.
    public static int calcNum(int n)
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

        //För denna for-loop används en array av storleken
        //tre för att kunna plocka ut rätt antal sätt att
        //klättra i trappan på för Davis. Detta genom att
        //använda modulo då tilldela det värdet till en plats
        //i arrayen.        
        int[] array = new int[3] { 1, 2, 4 };
        for (int i = 3; i < n; i++)
        {
            array[i % 3] = array[0] + array[1] + array[2];
        }
        return array[(n - 1) % 3];
    }

    static void Main(String[] args)
    {
        int s = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < s; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(calcNum(n));
        }
    }
}