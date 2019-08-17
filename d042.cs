using System;

public class Pz{
    public static void Main(){
        string[] arr = Console.ReadLine().Trim().Split(' ');
        int n1 = int.Parse(arr[0]);
        int n2 = int.Parse(arr[1]);
        arr = Console.ReadLine().Trim().Split(' ');
        int n3 = int.Parse(arr[0]);
        int n4 = int.Parse(arr[1]);
        
        Console.WriteLine(n1 * n4 - n2 * n3);
    }
}
