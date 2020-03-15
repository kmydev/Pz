using System;
using System.Text;
using System.Collections.Generic;

public class Pz{
    public static void Main(){
        var line = Console.ReadLine();
        var arr = line.Trim().Split(' ');
        int atk = int.Parse(arr[0]);
        int def = int.Parse(arr[1]);
        int agi = int.Parse(arr[2]);
        
        int n = int.Parse(Console.ReadLine().Trim());
        
        List<string> Names = new List<string>();
        
        for (int i = 0; i < n; i++)
        {
            arr = Console.ReadLine().Trim().Split(' ');
            var mns = new Monster(arr);
            if (mns.IsEvo(atk, def, agi))
            {
                Names.Add(mns.Name);
            }
        }

        if (Names.Count <= 0)
        {
            Names.Add("no evolution");
        }
        
        foreach (var name in Names)
        {
            Console.WriteLine(name);
        }
    }
}

public class Monster
{
    public string Name { get; set; }
    public int AtkMin { get; set; }
    public int AtkMax { get; set; }
    public int DefMin { get; set; }
    public int DefMax { get; set; }
    public int AgiMin { get; set; }
    public int AgiMax { get; set; }
    public Monster()
    {
        
    }
    
    public Monster(string[] arr)
    {
        Name = arr[0];
        AtkMin = int.Parse(arr[1]);
        AtkMax = int.Parse(arr[2]);
        DefMin = int.Parse(arr[3]);
        DefMax = int.Parse(arr[4]);
        AgiMin = int.Parse(arr[5]);
        AgiMax = int.Parse(arr[6]);
    }
    public bool IsEvo(int atk, int def, int agi)
    {
        if (atk < AtkMin || atk > AtkMax) return false;
        if (def < DefMin || def > DefMax) return false;
        if (agi < AgiMin || agi > AgiMax) return false;
        return true;
    }
}
