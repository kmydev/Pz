using System;

public class Pz{
    public static void Main(){
        string[] arr = Console.ReadLine().Trim().Split(' ');
        int t = int.Parse(arr[0]);
        int x = int.Parse(arr[1]);
        int y = int.Parse(arr[2]);
        int max_x = x;

        for (int i = 0; i < t; i++)
        {
            arr = Console.ReadLine().Trim().Split(' ');
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            x += a;
            y += b;
            if (max_x < x) max_x = x;
            if (y <= 0) break;
        }
        
        Console.WriteLine(max_x);
    }
}
