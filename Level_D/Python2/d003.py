# coding: utf-8

if (__name__=='__main__'):
    n = int(raw_input().strip())
    s = ''
    for i in range(1, 10):
      s += str(i * n) + ' '
    
    print s.strip()
