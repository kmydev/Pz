using System;

public class Pz{
    public static void Main(){
        string s = Console.ReadLine().Trim();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            Console.Write(s[i]);
        }
        Console.WriteLine();
    }
}
