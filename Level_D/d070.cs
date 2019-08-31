using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int m = int.Parse(arr[0]);
        int n = int.Parse(arr[1]);

        Console.WriteLine(m - n);
    }
}
