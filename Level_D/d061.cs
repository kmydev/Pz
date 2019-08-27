using System;

public class Pz{
    public static void Main(){
        int c = int.Parse(Console.ReadLine().Trim()) * 3;
        if (c == 0) c = 1;
        Console.WriteLine(c);
    }
}
