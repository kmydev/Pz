using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += int.Parse(arr[i]);
        }
        Console.WriteLine(sum);
    }
}
