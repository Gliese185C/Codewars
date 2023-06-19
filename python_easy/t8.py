'''

What if we need the length of the words separated by a space to be added at the end of that same word and have it returned as an array?

Example(Input --> Output)

"apple ban" --> ["apple 5", "ban 3"]
"you will win" -->["you 3", "will 4", "win 3"]
Your task is to write a function that takes a String and returns an Array/list with the length of each word added to each element .

Note: String will have at least one element; words will always be separated by a space.

'''

add_length = lambda str_: [item + ' ' + str(len(item)) for item in str_.split(' ') ]


'''
another examples

def add_length(s):
    return ['%s %d' % (x, len(x)) for x in s.split()]
    
def add_length(str_):
    return [f"{w} {len(w)}" for w in str_.split()]
    
def add_length(str_):
    return ["{} {}".format(i, len(i)) for i in str_.split(' ')]

'''