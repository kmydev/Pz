using System;

public class Pz{
    public static void Main(){
        string s = Console.ReadLine().Trim();
        int n = s.Replace("-", "").Length;
        int m = s.Replace("_", "").Length;
        Console.WriteLine((n < m) ? s.Replace("_", "-") : s.Replace("-", "_"));
    }
}
