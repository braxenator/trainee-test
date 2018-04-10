using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{


    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        //Räknare som ska användas för outputen.
        int[] arr = new int[1000];

        //Dictionary innehållandes en lista av strängar
        //för att koppla informationen till respektive nyckel.
        Dictionary<int, List<string>> arrayMap = new Dictionary<int, List<string>>();

        for (int a0 = 0; a0 < n; a0++)
        {
            string[] tokens_x = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(tokens_x[0]);
            string s = tokens_x[1];
            arr[x]++;

            //Här byts den första halvan av elementen ut till
            //bindesträck.
            if (a0 < n / 2)
                s = "-";

            //Om nyckeln x i arrayMappen finns så läggs
            //strängen s till, annars skapas en ny lista för
            //nyckeln x.
            if (arrayMap.ContainsKey(x))
                arrayMap[x].Add(s);
            else
                arrayMap.Add(x, new List<string> { s });
        }

        //Här går for-looparna igenom arrayMappen för
        //att skriva ut rätt sträng på rätt plats. Och
        //för att spara tid så används en StringBuilder
        //istället för att skriva ut varje rad inne i loopen.
        StringBuilder stringOutput = new StringBuilder("");
        for (int i = 0; i < arr.Count(); i++)
        {
            for (int j = 0; j < arr[i]; j++)
            {
                stringOutput.Append(arrayMap[i][j] + " ");
            }
        }

        Console.WriteLine(stringOutput);
        Console.ReadLine();
    }
}
