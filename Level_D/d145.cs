using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        var n = int.Parse(arr[0]);
        var m = int.Parse(arr[1]);
        Console.WriteLine(n / m);
    }
}
