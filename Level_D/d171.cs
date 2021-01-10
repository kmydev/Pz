using System;
using System.Text;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int p1 = int.Parse(arr[0]);
        int p2 = int.Parse(arr[1]);
        int n = int.Parse(Console.ReadLine().Trim());

        Console.WriteLine("{0} {1}", p1-n, p2-n);
    }
}
