using System;

public class Pz{
    public static void Main(){
        string s = Console.ReadLine().Trim();
        int n = int.Parse(s);
        for (int i = n; i > 0; i--)
        {
            Console.WriteLine(i);
        }
    }
}
