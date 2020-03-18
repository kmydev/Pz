using System;

public class Pz {
    public static void Main() {
        var s = Console.ReadLine().Trim();
        int n = int.Parse(Console.ReadLine().Trim());
        string ss = string.Format("{0}{1}", s.Substring(0, n-1), s.Substring(n, s.Length-n));
        Console.WriteLine(ss);
    }
}
