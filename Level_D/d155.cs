using System;

public class Pz{
    public static void Main(){
        int n = int.Parse(Console.ReadLine().Trim());
        var arr = Console.ReadLine().Trim().Split(' ');
        int m = int.Parse(arr[0]);
        int a = int.Parse(arr[1]);
        int b = int.Parse(arr[2]);

        int total = (n < m) ? n * b : n * a;

        Console.WriteLine(total);
    }
}
