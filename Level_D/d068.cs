using System;

public class Pz{
    public static void Main(){
        int n = int.Parse(Console.ReadLine().Trim());
        string s = Console.ReadLine().Trim();

        int ns = n - s.Replace("S", "").Length;
        int nr = n - s.Replace("R", "").Length;
        Console.WriteLine("{0} {1}", ns, nr);
    }
}
