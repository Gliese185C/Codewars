'''

Write function bmi that calculates body mass index (bmi = weight / height2).

if bmi <= 18.5 return "Underweight"

if bmi <= 25.0 return "Normal"

if bmi <= 30.0 return "Overweight"

if bmi > 30 return "Obese"


'''

def bmi(weight, height):
    wh = weight/height**2
    if wh <= 18.5: return 'Underweight'
    elif wh <= 25.0: return 'Normal'
    elif wh <= 30.0: return 'Overweight'
    return 'Obese'

'''
best solution 

def bmi(weight, height):
    b = weight / height ** 2
    return ['Underweight', 'Normal', 'Overweight', 'Obese'][(b > 30) + (b > 25) + (b > 18.5)]


'''