using System;
using System.Text;
using System.Collections.Generic;

public class LogInfo {
    public int ip1 { get; set; }
    public int ip2 { get; set; }
    public int ip3 { get; set; }
    public int ip4 { get; set; }
    public string logtime { get; set; }
    public string uri { get; set; }
    public override string ToString()
    {
        return string.Format("{0}.{1}.{2}.{3} {4} {5}", ip1, ip2, ip3, ip4, logtime, uri);
    }
}

public class Pz{
    public static void Main(){
        var ip = Console.ReadLine().Trim();
        int n = int.Parse(Console.ReadLine().Trim());
        
        List<LogInfo> loginfolist = new List<LogInfo>();
        for (int i = 0; i < n; i++)
        {
            var logstr = Console.ReadLine().Trim();
            LogInfo loginfo = getloginfo(logstr);
            if (loginfo != null) loginfolist.Add(loginfo);
        }
        
        var iparr = ip.Split('.');
        foreach (var loginfo in loginfolist)
        {
            if (isLog(iparr, loginfo))
            {
                Console.WriteLine(loginfo.ToString());
            }
        }
    }
    
    private static bool isLog(string[] iparr, LogInfo loginfo)
    {
        if (loginfo.ip1 != int.Parse(iparr[0])) return false;
        if (loginfo.ip2 != int.Parse(iparr[1])) return false;

        if (iparr[2] != "*")
        {
            if (iparr[2].StartsWith("["))
            {
                var s = iparr[2].Substring(1, iparr[2].IndexOf("]")-1);
                var sarr = s.Split('-');
                if (loginfo.ip3 < int.Parse(sarr[0]) || loginfo.ip3 > int.Parse(sarr[1])) return false;
            }
            else if (loginfo.ip3 != int.Parse(iparr[2])) return false;
        }

        if (iparr[3] != "*")
        {
            if (iparr[3].StartsWith("["))
            {
                var s = iparr[3].Substring(1, iparr[3].IndexOf("]")-1);
                var sarr = s.Split('-');
                if (loginfo.ip4 < int.Parse(sarr[0]) || loginfo.ip4 > int.Parse(sarr[1])) return false;
            }
            else if (loginfo.ip4 != int.Parse(iparr[3])) return false;
        }

        return true;
    }
    
    private static LogInfo getloginfo(string logstr)
    {
        LogInfo ret = new LogInfo();
        int n = logstr.IndexOf("-");
        var iparr = logstr.Substring(0, n).Trim().Split('.');
        ret.ip1 = int.Parse(iparr[0]);
        ret.ip2 = int.Parse(iparr[1]);
        ret.ip3 = int.Parse(iparr[2]);
        ret.ip4 = int.Parse(iparr[3]);
        var uriarr = logstr.Split('"');
        var uriarr2 = uriarr[1].Split(' ');
        ret.uri = uriarr2[1].Trim();
        var dtarr = logstr.Split('[');
        var dtarr2 = dtarr[1].Split(' ');
        ret.logtime = dtarr2[0].Trim();
        return ret;
    }
}

