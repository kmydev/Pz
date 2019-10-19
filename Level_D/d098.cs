using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        Console.WriteLine(int.Parse(arr[0]) * int.Parse(arr[1]));
    }
}
