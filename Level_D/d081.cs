using System;

public class Pz{
    public static void Main(){
        int n = int.Parse(Console.ReadLine().Trim());
        var arr = Console.ReadLine().Trim().Split(' ');
        int h = int.Parse(arr[0]);
        int w = int.Parse(arr[1]);
        Console.WriteLine((h * w) % n);
    }
}
