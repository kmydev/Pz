using System;

public class Pz{
    public static void Main(){
        string s = "3.141592653589793";
        int n = int.Parse(Console.ReadLine().Trim());
        Console.WriteLine(s.Substring(0, n+2));
    }
}
