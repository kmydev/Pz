using System;

public class Pz{
    public static void Main(){
        string m = "CAB";
        string s = Console.ReadLine().Trim();
        for (int i = 0; i < s.Length; i++)
        {
            Console.Write(m[int.Parse(s.Substring(i, 1))]);
        }
        Console.WriteLine();
    }
}
