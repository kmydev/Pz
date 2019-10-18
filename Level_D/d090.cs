using System;
using System.Text;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int sum = 0;
        foreach (string s in arr)
        {
            sum += int.Parse(s);
        }

        Console.WriteLine(sum % 10);
    }
}
