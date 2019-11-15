using System;
using System.Text;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int maxsum = 0;
        
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("{0}{1}{2}{3}", arr[0], arr[1], arr[2], arr[3]);
        for (int i = 0; i < 4; i++)
        {
            int ss = getShuffleSum(sb.ToString());
            maxsum = (maxsum < ss) ? ss : maxsum;
            sb.Remove(0, 1);
            sb.Append(arr[i]);
        }
        Console.WriteLine(maxsum);
    }
    
    private static int getShuffleSum(string s)
    {
        int ret = 0;

        int ml = int.Parse(s.Substring(0, 1)) * 10 + int.Parse(s.Substring(1, 1));
        int nl = int.Parse(s.Substring(1, 1)) * 10 + int.Parse(s.Substring(0, 1));
        int mr = int.Parse(s.Substring(2, 1)) * 10 + int.Parse(s.Substring(3, 1));
        int nr = int.Parse(s.Substring(3, 1)) * 10 + int.Parse(s.Substring(2, 1));

        if (ret < ml + mr) ret = ml + mr;
        if (ret < ml + nr) ret = ml + nr;
        if (ret < nl + mr) ret = nl + mr;
        if (ret < nl + nr) ret = nl + nr;

        return ret;
    }
}
