# coding: utf-8

if __name__=="__main__":
    arr = []
    line = raw_input().strip()
    arr.append('Gold {0}'.format(line))
    line = raw_input().strip()
    arr.append('Silver {0}'.format(line))
    line = raw_input().strip()
    arr.append('Bronze {0}'.format(line))

    for s in arr:
        print(s)
