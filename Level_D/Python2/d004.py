# coding: utf-8

if (__name__=='__main__'):
    n = int(raw_input().strip())
    s = ''
    for i in range(n):
      if len(s) > 0:
          s += ','
      s += raw_input().strip()

    s = 'Hello ' + s + '.'
    print s
