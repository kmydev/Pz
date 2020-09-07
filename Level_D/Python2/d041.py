# coding: utf-8

if __name__=='__main__':
    arr = raw_input().strip().split(' ')
    n = int(arr[0])
    d = int(arr[1])
    e = int(arr[2])
    if n <= d * e:
        print('OK')
    else:
        print('NG')
