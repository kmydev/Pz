using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int m = int.Parse(arr[0]);
        int v = int.Parse(arr[1]);
        int f = int.Parse(arr[2]);
        int l = (m * v * v) / (2 * f);
        Console.WriteLine(l);
    }
}
