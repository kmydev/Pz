using System;
using System.Text;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int ans = 0;
        foreach (string s in arr)
        {
            ans += (int.Parse(s) <= 2) ? 1 : 0;
        }

        Console.WriteLine(ans);
    }
}
