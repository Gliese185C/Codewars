'''

Your coworker was supposed to write a simple helper function to capitalize a string (that contains a single word) before they went on vacation.

Unfortunately, they have now left and the code they gave you doesn't work. Fix the helper function they wrote so that it works as intended (i.e. make the first character in the string "word" upper case).

Don't worry about numbers, special characters, or non-string types being passed to the function. The string lengths will be from 1 character up to 10 characters, but will never be empty.

 def basic_test_cases():
        test.assert_equals(capitalize_word('word'), 'Word')
        test.assert_equals(capitalize_word('i'), 'I')
        test.assert_equals(capitalize_word('glasswear'), 'Glasswear')

'''


def capitalize_word(word):
    return "".join(word[i].upper() if i == 0 else word[i] for i in range(len(word)))



''' 

def capitalizeWord(word):
    return word.capitalize()
    
def capitalizeWord(s):
    return s.title()

capitalizeWord = str.capitalize

def capitalizeWord(word):
    return word[0].upper() + word[1:]
    
def capitalize_word(word):

    return "".join(char.capitalize() for char in word.split())

'''