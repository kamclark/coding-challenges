# Write a function that will return the count of distinct case-insensitive alphabetic characters 
# and numeric digits that occur more than once in the input string. 
# The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.

# "abcde" -> 0 # no characters repeats more than once
# "aabbcde" -> 2 # 'a' and 'b'
# "aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
# "indivisibility" -> 1 # 'i' occurs six times
# "Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
# "aA11" -> 2 # 'a' and '1'
# "ABBA" -> 2 # 'A' and 'B' each occur twice

def duplicate_count(text):
     text = text.lower() # all lowercase conversion
     d1 = {} # empty dictionary for counting original string char occurences
     d2 = {} # empty dictionary for new list of values higher than 1 using list comprehension


     for i in text: # for each char in input string
         if not i in d1:  # if char is not key in dictionary
             d1[i] = 1 # dictionary key is char, value initialised at 1. 
         else: 
            d1[i] += 1 # increase value by 1, since present again in string

     d2 =  {key: d1[key] for key in d1 if d1[key] > 1} # if value of key in d1 is greater than 1, add key and corresponding value to d2

     for j in d2 : # for each key in d2
        print ("{} was found {} times!".format(j, d2.get(j))) # display string with key and value of current key iteration
     return d2

print (duplicate_count("insensitive"))

