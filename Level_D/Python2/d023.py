# coding: utf-8
import os

if __name__=='__main__':
  s = raw_input().strip()
  t = s.replace('A', '')
  print len(s)-len(t)
