using System;

public class Pz{
    public static void Main(){
        string s = Console.ReadLine().Trim();
        Console.WriteLine((s.Length >= 11) ? "OK" : (11 - s.Length).ToString());
    }
}
