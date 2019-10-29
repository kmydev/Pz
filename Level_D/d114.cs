using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int a = int.Parse(arr[0]);
        int b = int.Parse(arr[1]);
        int ans = b * (100 + a) / 100;
        Console.WriteLine(ans);
    }
}
