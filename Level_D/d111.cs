using System;

public class Pz{
    public static void Main(){
        int n = int.Parse(Console.ReadLine().Trim());
        string s = Console.ReadLine().Trim();
        Console.WriteLine(s.Substring(0, n));
    }
}
