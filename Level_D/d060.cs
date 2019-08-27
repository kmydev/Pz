using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int a = int.Parse(arr[0]);
        int b = int.Parse(arr[1]);
        Console.WriteLine(a - b);
    }
}
