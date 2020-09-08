# coding: utf-8

if __name__=="__main__":
    line = raw_input().strip()
    s = line.replace('S', '').replace(' ', '')
    if len(s) >= 5:
        print('OK')
    else:
        print('NG')
