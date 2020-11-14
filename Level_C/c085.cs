using System;
using System.Text;

public class Pz{
    public static void Main(){
        int[] arrNum = new int[26];
        var arr = Console.ReadLine().Trim().Split(' ');
        for (int i = 0; i < 26; i++)
        {
            arrNum[i] = int.Parse(arr[i]);
        }
        var outstr = Console.ReadLine().Trim();

        int chbase = (int)'a';      
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < outstr.Length; i++)
        {
            char ch = outstr[i];
            int pos = (int)ch - chbase;
            if (arrNum[pos] > 0)
            {
                sb.Append(ch);
                arrNum[pos]--;
            }
        }
        Console.WriteLine(sb.ToString());
    }
}
