class Solution:
    def evalRPN(self, tokens):
        stack = []

        ops = {
            "+": lambda a, b: b + a,
            "-": lambda a, b: b - a,
            "*": lambda a, b: b * a,
            "/": lambda a, b: int(b / a)
        }

        for t in tokens:
            if t in ops:
                a = stack.pop()
                b = stack.pop()
                stack.append(ops[t](a, b))
            else:
                stack.append(int(t))

        return stack[0]