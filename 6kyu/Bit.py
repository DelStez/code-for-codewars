# Implement a function that adds two numbers together
# and returns their sum in binary.
# The conversion can be done before, or after the addition.
def count_bits(n):
    return "{0:b}".format(n).count("1")
