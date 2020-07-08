using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int k = int.Parse(arr[0]);
        int n = int.Parse(arr[1]);
        int pt = 100 / n;
        
        List<string> anslist = new List<string>();
        for (int i = 0; i < k; i++)
        {
            arr = Console.ReadLine().Trim().Split(' ');
            int d = int.Parse(arr[0]);
            int a = int.Parse(arr[1]);
            anslist.Add(getHyoka(pt, d, a));
        }
        
        foreach (var ans in anslist)
        {
            Console.WriteLine(ans);
        }
    }
    
    private static string getHyoka(int pt, int d, int a)
    {
        double pts = pt * a;
        if (d > 0 && d <= 9)
        {
            pts *= 0.8;
        }
        else if (d >= 10)
        {
            pts = 0;
        }
        
        if (pts >= 80.0)
        {
            return "A";
        }
        else if (pts >= 70.0)
        {
            return "B";
        }
        else if (pts >= 60.0)
        {
            return "C";
        }
        
        return "D";
    }
}
