'''

Make a function that returns the value multiplied by 50 and increased by 6. If the value entered is a string it should return "Error".

def basic_test_cases():
        test.assert_equals(problem("hello"), "Error")
        test.assert_equals(problem(1), 56)

'''


problem = lambda a: a * 50 + 6 if type(a) == int or type(a) == float else 'Error'
