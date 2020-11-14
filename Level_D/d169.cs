using System;
using System.Text;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int h = int.Parse(arr[0]);
        int l = int.Parse(arr[1]);
        Console.WriteLine(h-l);
    }
}
