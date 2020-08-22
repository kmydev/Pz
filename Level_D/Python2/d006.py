# coding: utf-8

dict1 = {'cm':10, 'm':1000, 'km':1000000}

if (__name__=='__main__'):
    arr = raw_input().strip().split(' ')
    n = int(arr[0])
    s = arr[1]

    print n * dict1[s]
