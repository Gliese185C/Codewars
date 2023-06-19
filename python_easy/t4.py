'''

Create a function called shortcut to remove the lowercase vowels (a, e, i, o, u ) in a given string.

Examples
    "hello"     -->  "hll"
    "codewars"  -->  "cdwrs"
    "goodbye"   -->  "gdby"
    "HELLO"     -->  "HELLO"

'''


shortcut = lambda s: ''.join( char for char in s if char not in ['a','e','i','o','u'])



'''

def shortcut(s):
    return ''.join(c for c in s if c not in 'aeiou')

'''