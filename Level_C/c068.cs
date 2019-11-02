using System;
using System.Text;
public class Pz{
    public static void Main(){
        int n = int.Parse(Console.ReadLine().Trim());
        string s = Console.ReadLine().Trim();
        StringBuilder ans = new StringBuilder();
        
        for (int i = 0; i < s.Length; i++)
        {
            ans.Append(getChar(s[i], n, i+1));
        }
        Console.WriteLine(ans.ToString());
    }
    
    private static char getChar(char c, int n, int id)
    {
        char ret;
        if (id % 2 == 0)
        {
            // 偶数=順方向
            ret = (char)((int)c + n);
            if (ret > 'Z')
            {
                ret = (char)((int)ret - 26);
            }
        }
        else
        {
            // 奇数=逆方向
            ret = (char)((int)c - n);
            if (ret < 'A')
            {
                ret = (char)((int)ret + 26);
            }
        }
        return ret;
    }
}
