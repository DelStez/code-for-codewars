## Replace With Alphabet Position

In this kata you are required to, given a string, replace every letter with its position in the alphabet.

If anything in the text isn't a letter, ignore it and don't return it.

`"a" = 1`, `"b" = 2`, etc.

### Given Code


```python
def alphabet_position(text):
    pass
```

---

### Solution


```python
import string
def alphabet_position(text):
    az = string.ascii_lowercase
    return " ".join([str(az.find(c) + 1) for c in text.lower() if c in az])
```

---
