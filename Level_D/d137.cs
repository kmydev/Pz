using System;

public class Pz{
    public static void Main(){
        string s = Console.ReadLine().Trim();
        Console.WriteLine(s.Length - s.Replace("y", "").Length);
    }
}
