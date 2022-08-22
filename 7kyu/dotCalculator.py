# You have to write a calculator that receives strings for input.
# The dots will represent the number in the equation.
# There will be dots on one side, an operator, and dots again after the operator.
# The dots and the operator will be separated by one space.
import operator

ops = {
    '+' : operator.add,
    '-' : operator.sub,
    '*' : operator.mul,
    '//' : operator.floordiv
}

def eval_binary_expr(op1, oper, op2):
    op1, op2 = int(op1), int(op2)
    return ops[oper](op1, op2)

def calculator(txt):
    array = txt.split(' ')
    x = eval_binary_expr(len(array[0]), array[1], len(array[2]))
    return "." * x