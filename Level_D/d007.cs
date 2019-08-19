using System;
using System.Text;

public class Pz{
    public static void Main(){
        string line = Console.ReadLine().Trim();
        int n = int.Parse(line);

        for (int i = 0; i < n; i++) Console.Write("*");
        Console.WriteLine();
    }
}
