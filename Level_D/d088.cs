using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int t = int.Parse(arr[0]);
        int u = int.Parse(arr[1]);
        Console.WriteLine(Math.Abs(t-u));
    }
}
