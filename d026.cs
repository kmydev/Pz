using System;

public class Pz{
    public static void Main(){
        int n = 0;
        
        for (int i = 0; i < 7; i++)
        {
            string s = Console.ReadLine().Trim();
            n += (s == "no") ? 1 : 0;
        }

        Console.WriteLine(n);
    }
}
