class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        stack = list()
        for i in tokens:
            if i in "+-*/":
                b = int(stack.pop())
                a = int(stack.pop())
                if i == "+": stack.append(a+b)
                if i == "-": stack.append(a-b)
                if i == "*": stack.append(a*b)
                if i == "/": stack.append(a/b)
            else:
                stack.append(i)
        return int(stack[0])