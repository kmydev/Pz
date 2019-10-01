using System;

public class Pz{
    public static void Main(){
        string w = Console.ReadLine().Trim();
        string s = Console.ReadLine().Trim();
        Console.WriteLine((s.Contains(w)) ? "NG" : s);
    }
}
