using System;
using System.Text;

public class Pz{
    public static void Main(){
        int s = int.Parse(Console.ReadLine().Trim());
        
        var arr = Console.ReadLine().Trim().Split(' ');
        int h = 50;
        for (int i = 0; i < 4; i++)
        {
            int a = int.Parse(arr[i]);
            h = (h > a) ? a : h;
        }

        Console.WriteLine(s * h);
    }
}
