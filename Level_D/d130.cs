using System;

public class Pz{
    public static void Main(){
        string[] arr = Console.ReadLine().Trim().Split(' ');
        int a = int.Parse(arr[0]);
        int b = int.Parse(arr[1]);
        int c = int.Parse(arr[2]);
        int d = int.Parse(arr[3]);
        int s = (int)((0.5 * (double)Math.Abs(a * d - b * c)) + 0.9999);

        Console.WriteLine(s);
    }
}
