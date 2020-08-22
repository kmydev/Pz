# coding: utf-8

if (__name__=='__main__'):
    arr = raw_input().strip().split(' ')
    m = int(arr[0])
    n = int(arr[1])
    s = ''
    
    for i in range(10):
      s += str(m + n * i) + ' '

    print s.strip()
