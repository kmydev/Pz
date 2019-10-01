using System;

public class Pz{
    public static void Main(){
        int[] narr = new int[4];
        for (int i = 0; i < 4; i++)
        {
            narr[i] = int.Parse(Console.ReadLine().Trim());
        }
        Console.WriteLine(getBlankNo(narr));
    }
    
    private static int getBlankNo(int[] narr)
    {
        int ret = 0;
        for (int no = 1; no <= 5; no++)
        {
            bool isNo = false;
            for (int i = 0; i < narr.Length; i++)
            {
                if (narr[i] == no)
                {
                    isNo = true;
                    break;
                }
            }
            
            if (!isNo)
            {
                ret = no;
                break;
            }
        }
        
        return ret;
    }
}
