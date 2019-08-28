using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int m = int.Parse(arr[0]);
        int n = int.Parse(arr[1]);
        int o = n - m;
        Console.WriteLine((o >= 0) ? o.ToString() : "No");
    }
}
