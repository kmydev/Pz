using System;

public class Pz{
    public static void Main(){
        int n = int.Parse(Console.ReadLine().Trim());
        int m = (21 % n == 0) ? n : 21 % n;
        Console.WriteLine(m);
    }
}
