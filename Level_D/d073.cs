using System;
using System.Text;

public class Pz{
    public static void Main(){
        string s = Console.ReadLine().Trim();
        Console.WriteLine(strReverse(s));
    }
    
    private static string strReverse(string s)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in s)
        {
            sb.Insert(0, c);
        }
        return sb.ToString();
    }
}
