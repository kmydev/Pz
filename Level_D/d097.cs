using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int n = 0;
        foreach (string s in arr) n += int.Parse(s);

        Console.WriteLine((n >= 5) ? "yes" : "no");
    }
}
