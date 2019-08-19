using System;

public class Pz{
    public static void Main(){
        int a = int.Parse(Console.ReadLine().Trim());
        int b = int.Parse(Console.ReadLine().Trim());
        int c = int.Parse(Console.ReadLine().Trim());

        Console.WriteLine((a == b && a == c) ? "YES" : "NO");
    }
}
