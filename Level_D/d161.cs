using System;
using System.Text;

public class Pz{
    public static void Main(){
        int max = int.Parse(Console.ReadLine().Trim());
        int cur = 0;
        for (int i = 0; i < 7; i++)
        {
            cur += int.Parse(Console.ReadLine().Trim());
        }
        Console.WriteLine((max < cur) ? max : cur);
    }
}
