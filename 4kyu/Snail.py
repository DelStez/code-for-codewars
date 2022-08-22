# Given an n x n array, return the array elements arranged
# from outermost elements to the middle element, traveling clockwise.
def snail(array):
    out = []
    while len(array):
        out += array.pop(0)
        array = list(zip(*array))[::-1]
    return out
