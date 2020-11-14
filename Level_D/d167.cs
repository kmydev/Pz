using System;
using System.Text;

public class Pz{
    public static void Main(){
        int n = int.Parse(Console.ReadLine().Trim());
        if (n >= 1000) n += 3;
        Console.WriteLine(n);
    }
}
