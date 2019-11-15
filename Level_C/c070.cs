using System;
using System.Text;

public class Pz{
    public static void Main(){
        int n = int.Parse(Console.ReadLine().Trim());
        StringBuilder sb = new StringBuilder();
        string[] sarr = new string[n];
        for (int i = 0; i < n; i++)
        {
            sarr[i] = Console.ReadLine().Trim();
            //test
            sb.Append(getHandStr(sarr[i]));
            sb.Append(Environment.NewLine);
        }
        Console.Write(sb.ToString());
    }
    
    private static string getHandStr(string s)
    {
        string[] pairs = { "No Pair", "One Pair", "Two Pair" };
        char[] carr = new char[4];
        for (int i = 0; i < 4; i++)
        {
            carr[i] = s[i];
        }
        
        // FourCard
        if (isFourCard(carr)) return "Four Card";
        // ThreeCard
        if (isThreeCard(carr)) return "Three Card";
        // Pairs
        int cnt = countPairs(carr);
        
        return pairs[cnt];
    }
    
    private static bool isFourCard(char[] carr)
    {
        return (carr[0] == carr[1] && carr[0] == carr[2] && carr[0] == carr[3]);
    }
    
    private static bool isThreeCard(char[] carr)
    {
        for (int i = 0; i < 2; i++)
        {
            int p = 0;
            for (int j = i + 1; j < 4; j++)
            {
                if (carr[i] == carr[j]) p++;
            }
            if (p == 2) return true;
        }
        
        return false;
    }
    
    private static int countPairs(char[] carr)
    {
        int cnt = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = i + 1; j < 4; j++)
            {
                if (carr[i] == carr[j]) cnt++;
            }
        }
        
        return cnt;
    }
}
