using System;

public class Pz{
    public static void Main(){
        string s = Console.ReadLine().Trim();
        if (s == "candy" || s == "chocolate")
        {
            Console.WriteLine("Thanks!");
        }
        else
        {
            Console.WriteLine("No!");
        }
    }
}
