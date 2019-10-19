using System;

public class Pz{
    public static void Main(){
        int n = int.Parse(Console.ReadLine().Trim());
        Console.WriteLine((n % 1111 == 0 || n % 11111 == 0) ? n.ToString() : "No");
    }
}
