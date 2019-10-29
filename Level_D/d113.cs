using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(':');
        int h = int.Parse(arr[0]) - 8;
        if (h < 0) h = 24 + h;
        Console.WriteLine("{0}:{1}", h, arr[1]);
    }
}
