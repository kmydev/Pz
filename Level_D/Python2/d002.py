# coding: utf-8

if (__name__=='__main__'):
    arr = raw_input().strip().split(' ')
    a = int(arr[0])
    b = int(arr[1])
    if a > b:
      print a
    elif a < b:
      print b
    else:
      print 'eq'
