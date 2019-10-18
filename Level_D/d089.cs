using System;
using System.Text;

public class Pz{
    public static void Main(){
        string s = Console.ReadLine().Trim();
        int res = 0;
        try
        {
            for (int i = 0; i < s.Length; i++)
            {
                res = int.Parse(s.Substring(0, i+1));
            }
        }
        catch
        {
        }

        Console.WriteLine(res);
    }
}
