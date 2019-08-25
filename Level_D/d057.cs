using System;

public class Pz{
    public static void Main(){
        int g = int.Parse(Console.ReadLine().Trim());
        string[] arr = Console.ReadLine().Trim().Split(' ');
        Console.WriteLine(arr[g-1]);
    }
}
