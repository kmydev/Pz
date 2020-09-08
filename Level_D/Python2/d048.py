# coding: utf-8

if __name__=="__main__":

    g = []
    
    d1 = int(raw_input().strip())
    for i in range(4):
        d = int(raw_input().strip())
        g.append(d-d1)
        d1 = d

    for i in range(4):
        print(g[i])
