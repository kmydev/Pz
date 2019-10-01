using System;

public class Pz{
    public static void Main(){
        var s = Console.ReadLine().Trim();
        int n = 0;
        foreach (char c in s)
        {
            n++;
            Console.Write(c);
            if (n % 10 == 0) Console.Write(Environment.NewLine);
        }
    }
}
