using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        float pts = 0;
        foreach (string pt in arr)
        {
            pts += float.Parse(pt);
        }
        float avg = pts / (float)arr.Length;
        float x = float.Parse(Console.ReadLine().Trim());
        Console.WriteLine((avg >= x) ? "pass" : "failure");
    }
}
