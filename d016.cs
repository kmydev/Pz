using System;

public class Pz{
    public static void Main(){
        string s = Console.ReadLine().Trim();
        int n = int.Parse(Console.ReadLine().Trim());

        Console.WriteLine(s.Substring(0, n));
    }
}
