using System;
using System.Text;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int p1 = int.Parse(arr[0]);
        int p2 = int.Parse(arr[1]);
        int s = int.Parse(Console.ReadLine().Trim());

        int sum = (p1 >= s) ? p1+p2 : p1;        

        Console.WriteLine(sum);
    }
}
