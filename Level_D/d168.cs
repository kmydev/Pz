using System;
using System.Text;

public class Pz{
    public static void Main(){
        string[] arr = new string[3];
        for (int i = 0; i < 3; i++)
        {
            arr[i] = Console.ReadLine().Trim();
        }

        Console.WriteLine("{0}/{1}/{2}", arr[1], arr[2], arr[0]);
    }
}
