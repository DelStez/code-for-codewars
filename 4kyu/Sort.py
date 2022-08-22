#You are given a binary tree:
# Your task is to return the list with elements from tree sorted by levels,
# which means the root element goes first, then root children
# (from left to right) are second and third, and so on.
# Return empty array if root is nil.
def tree_by_levels(node):
    p, q = [], [node]
    while q:
        v = q.pop(0)
        if v is not None:
            p.append(v.value)
            q += [v.left,v.right]
    return p if not node is None else []
