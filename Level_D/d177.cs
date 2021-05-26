using System;
using System.Text;

public class Pz{
    public static void Main(){
        var s = Console.ReadLine().Split(' ');
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);

        Console.WriteLine(a*b);
    }
}
