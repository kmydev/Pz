using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int x = int.Parse(arr[0]);
        int y = int.Parse(arr[1]);
        int p = int.Parse(arr[2]);
        int n = (x + (y - 1)) / y;
        Console.WriteLine(n * p);
    }
}
