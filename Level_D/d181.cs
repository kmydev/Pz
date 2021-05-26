using System;
using System.Text;

public class Pz{
    public static void Main(){
        string s = "";
        for (int i = 0; i < 3; i++)
        {
            s += Console.ReadLine().Trim() + "-";
        }
        Console.WriteLine(s.Substring(0, s.Length-1));
    }
}
