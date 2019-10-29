using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int ans = 1;
        foreach (string s in arr)
        {
            ans *= int.Parse(s);
        }
        Console.WriteLine(ans);
    }
}
