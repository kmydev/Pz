using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');

        float sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += float.Parse(arr[i]);
        }

        Console.WriteLine("{0:0.0}", sum / arr.Length);
    }
}
