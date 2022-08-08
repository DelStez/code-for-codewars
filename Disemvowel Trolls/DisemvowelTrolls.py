import re

def disemvowel(string_):
    return re.sub('[aeiuoOAEUI]', '', string_)
