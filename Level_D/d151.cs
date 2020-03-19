using System;

public class Pz{
    public static void Main(){
        var s = Console.ReadLine().Trim();
        int n = int.Parse(Console.ReadLine().Trim());
        int ans = 0;
        if (s == "chocolate") ans = n * 2;
        else if (s == "cake") ans = n * 5;
        Console.WriteLine(ans);
    }
}
