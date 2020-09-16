# coding: utf-8

if __name__=="__main__":
    n = int(raw_input().strip())
    if n==1 or n==2 or n==4 or n==8 or n==16 or n==32 or n==64 or n==128 or n==256:
        print('OK')
    else:
        print('NG')
