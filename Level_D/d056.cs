using System;

public class Pz{
    public static void Main(){
        string[] arr = Console.ReadLine().Trim().Split(' ');
        int r1 = int.Parse(arr[0]);
        int r2 = int.Parse(arr[1]);
        Console.WriteLine((r1 * r1 * r1) - (r2 * r2 * r2));
    }
}
