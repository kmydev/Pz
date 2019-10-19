using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int n = int.Parse(arr[0]);
        int m = int.Parse(arr[1]);
        Console.WriteLine(((n + m) % 2 == 0) ? "NO" : "YES");
    }
}
