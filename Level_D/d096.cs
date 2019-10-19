using System;

public class Pz{
    public static void Main(){
        string s = Console.ReadLine().Trim();
        Console.WriteLine((s.Contains("i") || s.Contains("I") || s.Contains("l")) ? "caution" : s);
    }
}
