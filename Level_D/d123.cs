using System;

public class Pz{
    public static void Main(){
        int x = int.Parse(Console.ReadLine().Trim());
        x += (x < 10000) ? 10000 : 0;
        Console.WriteLine(x);
    }
}
