using System;

public class Pz{
    public static void Main(){
        var s = Console.ReadLine().Trim();
        int n = s.Length - s.Replace("W", "").Length;
        Console.WriteLine((n >= 5) ? "OK" : "NG");
    }
}
