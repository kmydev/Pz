# coding: utf-8

if __name__=='__main__':
    arr = raw_input().strip().split(' ')

    if arr[1]=='M':
        print('Hi, Mr. {0}'.format(arr[0]))
    else:
        print('Hi, Ms. {0}'.format(arr[0]))
