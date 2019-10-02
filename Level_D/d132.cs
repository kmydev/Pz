using System;

public class Pz{
    public static void Main(){
        int n = int.Parse(Console.ReadLine().Trim());
        string s = Console.ReadLine().Trim();
        for (int i = 0; i < n; i++)
        {
            Console.Write(s);
        }
        Console.WriteLine();
    }
}
