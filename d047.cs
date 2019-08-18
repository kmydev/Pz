using System;
using System.Text;

public class Pz{
    public static void Main(){
        string[] marr = {"Gold", "Silver", "Bronze"};
        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < 3; i++)
        {
            sb.AppendFormat("{0} {1}\n", marr[i], Console.ReadLine().Trim());
        }
        
        Console.WriteLine(sb.ToString());
    }
}
