using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int d1 = int.Parse(arr[0]);
        int d2 = int.Parse(arr[1]);
        d1 = (d1 > 5) ? 5 : d1;
        d2 = (d2 > 5) ? 5 : d2;
        Console.WriteLine(d1 + d2);
    }
}
