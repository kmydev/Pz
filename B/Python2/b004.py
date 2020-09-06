# coding: utf-8

def compareOctet(tgt, log):
    logvalue = int(log)
    if tgt == '*':
        return True
    
    if tgt[0]=='[':
        arr = tgt.replace('[','').replace(']','').split('-')
        minIp = int(arr[0])
        maxIp = int(arr[1])
        if logvalue >= minIp and logvalue <= maxIp:
            return True
        else:
            return False
    
    ip = int(tgt)
    if logvalue == ip:
        return True

    return False

    
def withinIPAddr(tgt, log):
    tgtarr = tgt.strip().split('.')
    logarr = log.strip().split('.')
    
    for i in range(4):
        if compareOctet(tgtarr[i], logarr[i]) == False:
            return False
    
    return True


def genOutStr(log):
    arr = log.split(' ')
    ip = arr[0]
    dt = arr[3].replace('[', '')
    cmd = arr[6]
    return '{0} {1} {2}'.format(ip, dt, cmd)
    
    
if __name__=="__main__":
    ipaddr = raw_input().strip()
    n = int(raw_input().strip())
    
    logs = []
    for i in range(n):
        line = raw_input().strip()
        logs.append(line)

    for log in logs:
        arr = log.split(' ')
        if withinIPAddr(ipaddr, arr[0]) == True:
            print genOutStr(log)
