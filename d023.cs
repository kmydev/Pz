using System;

public class Pz{
    public static void Main(){
        string s = Console.ReadLine().Trim();
        string t = s.Replace("A", "");

        Console.WriteLine(s.Length - t.Length);
    }
}
