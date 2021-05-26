using System;
using System.Text;

public class Pz{
    public static void Main(){
        var n = Console.ReadLine().Split(' ');
        var f1 = int.Parse(n[0]);
        var f2 = int.Parse(n[1]);

        Console.WriteLine(Math.Abs(f1-f2));
    }
}
