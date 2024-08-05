import string

def alphabet_position(text):
    az = string.ascii_lowercase
    return " ".join([str(az.find(c) + 1) for c in text.lower() if c in az])
