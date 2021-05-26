using System;
using System.Text;

public class Pz{
    public static void Main(){
        var s = Console.ReadLine().Trim();

        Console.WriteLine((s.Length <= 20) ? "OK" : "NG");
    }
}
