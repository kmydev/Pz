using System;
using System.Text;

public class Pz{
    public static void Main(){
        string line = Console.ReadLine().Trim();
        string[] arr = line.Split(' ');
        int a = int.Parse(arr[0]);
        int b = int.Parse(arr[1]);

        Console.WriteLine(b - a);
    }
}
