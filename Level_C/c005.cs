using System;

public class Pz{
    public static void Main(){
        int n = int.Parse(Console.ReadLine().Trim());
        string s = "";
        for (int i = 0; i < n; i++)
        {
            var arr = Console.ReadLine().Trim().Split('.');
            s += getAns(arr);
        }
        
        Console.Write(s);
    }
    
    private static string getAns(string[] arr)
    {
        if (arr.Length != 4) return "False\n";
        
        for (int i = 0; i < 4; i++)
        {
            if (arr[i].Length <= 0 || arr[i].Length > 3)
            {
                return "False\n";
            }
            int oct = int.Parse(arr[i]);
            if (oct < 0 || oct > 255)
            {
                return "False\n";
            }
        }
        
        return "True\n";
    }
}
