def is_valid_walk(walk):
    ns = walk.count('n') == walk.count("s")
    ew = walk.count('e') == walk.count("w")
    l = len(walk) == 10
    return ns and ew and l
