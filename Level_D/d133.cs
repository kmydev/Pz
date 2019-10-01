using System;

public class Pz{
    public static void Main(){
        int x = int.Parse(Console.ReadLine().Trim());
        int a = int.Parse(Console.ReadLine().Trim());
        int b = int.Parse(Console.ReadLine().Trim());

        int n = x / a;
        Console.WriteLine(n * b - n * a);
    }
}
