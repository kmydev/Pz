using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class Pz{
    public static void Main(){
        int n = int.Parse(Console.ReadLine().Trim());
        List<string> socksList = new List<string>();
        
        for (int i = 0; i < n; i++)
        {
            socksList.Add(Console.ReadLine().Trim());
        }
        
        int pairs = 0;
        while (socksList.Count > 1)
        {
            int a1 = socksList.Count - 1;
            string s1 = socksList[a1];
            socksList.RemoveAt(a1);
            string s2 = s1.Substring(0, 1);
            if (s1.Substring(2, 1) == "R")
            {
                s2 += " L";
            }
            else
            {
                s2 += " R";
            }
            for (int i = socksList.Count - 1; i >= 0; i--)
            {
                if (socksList[i] == s2)
                {
                    pairs++;
                    socksList.RemoveAt(i);
                    break;
                }
            }
        }
        
        Console.WriteLine(pairs);
    }
}
