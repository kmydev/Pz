using System;

public class Pz{
    public static void Main(){
        int n = int.Parse(Console.ReadLine().Trim());
        string[] flowersCalendar = new string[n];

        for (int i = 0; i < n; i++)
        {
            char[] tmpchr = new char[30];
            for (int c = 0; c < 30; c++) tmpchr[c] = '0';
            var arr = Console.ReadLine().Trim().Split(' ');
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            if (a + b < 30) tmpchr[a + b - 1] = '1';
            flowersCalendar[i] = new string(tmpchr);
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(flowersCalendar[i]);
        }
        
        int max_day = 1;
        int max_flowers = 0;
        for (int i = 29; i >= 0; i--)
        {
            int cnt = 0;
            for (int j = 0; j < n; j++)
            {
                if (flowersCalendar[j][i] == '1') cnt++;
            }
            if (max_flowers <= cnt)
            {
                max_flowers = cnt;
                max_day = i + 1;
            }
        }

        Console.WriteLine(max_day);
    }
}
