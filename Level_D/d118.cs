using System;

public class Pz{
    public static void Main(){
        string s = Console.ReadLine().Trim();
        int n = int.Parse(Console.ReadLine().Trim());
        int y = (s == "S") ? 1925 : 1988;
        Console.WriteLine(y + n);
    }
}
