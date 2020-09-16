using System;
using System.Text;

public class Pz{
    public static void Main(){
        int n = int.Parse(Console.ReadLine().Trim());
        bool f = false;
        
        int nn = 1;
        for (int i = 0; i < 9; i++)
        {
            if (n == nn)
            {
                f = true;
                break;
            }
            
            nn *= 2;
        }
        
        
        Console.WriteLine((f) ? "OK":"NG");
    }
}
