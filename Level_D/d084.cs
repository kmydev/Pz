using System;

public class Pz{
    public static void Main(){
        int m = int.Parse(Console.ReadLine().Trim());
        DateTime d = new DateTime(2000, m, 1, 0, 0, 0);
        Console.WriteLine(d.ToString("MMMM"));
    }
}
