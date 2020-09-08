# coding: utf-8

if __name__=="__main__":
    line = raw_input().strip()
    n = 11 - len(line)
    if n <= 0:
        print('OK')
    else:
        print(n)
