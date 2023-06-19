'''
Build a function that returns an array of integers from n to 1 where n>0.

Example : n=5 --> [5,4,3,2,1]


'''

reverse_seq = lambda n: list(range(1,n+1))[::-1]



'''
best solution

def reverseseq(n):
    return range(n, 0, -1)

'''