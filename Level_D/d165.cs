using System;
using System.Text;

public class Pz{
    public static void Main(){
        string s = Console.ReadLine().Trim();
        bool f = false;
        
        for (int i = 0; i <= 9; i++)
        {
            string ss = i.ToString();
            if (s.Replace(ss, "").Length <= 2)
            {
                f = true;
                break;
            }
        }

        Console.WriteLine((f) ? "NG":"OK");
    }
}
