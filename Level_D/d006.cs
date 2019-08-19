using System;
using System.Text;

public class Pz{
    public static void Main(){
        string line = Console.ReadLine().Trim();
        string[] arr = line.Split(' ');
        int n = int.Parse(arr[0]);
        string s = arr[1];
        int multi = 1;

        if (s == "km")
        {
            multi *= 1000000;
        }
        else if (s == "m")
        {
            multi *= 1000;
        }
        else if (s == "cm")
        {
            multi *= 10;
        }

        Console.WriteLine((n * multi).ToString());
    }
}
