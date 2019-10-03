using System;
using System.Text;

public class Pz{
    public static void Main(){
        int n= int.Parse(Console.ReadLine().Trim());
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.Append(Console.ReadLine().Trim());
        }
        Console.WriteLine(sb.ToString());
    }
}
