

class MinStack {
    private long min;
    private Stack<Long> stack;

    public MinStack() {
        stack = new Stack<>();
        min = 0;
    }

    public void push(int val) {
        if (stack.isEmpty()) {
            stack.push(0L);
            min = val;
        } else {
            long diff = val - min;
            stack.push(diff);

            if (val < min) {
                min = val;
            }
        }
    }

    public void pop() {
        if (stack.isEmpty()) return;

        long diff = stack.pop();

        if (diff < 0) {
            min = min - diff;
        }
    }

    public int top() {
        long top = stack.peek();

        if (top > 0) {
            return (int)(top + min);
        } else {
            return (int)min;
        }
    }

    public int getMin() {
        return (int)min;
    }
}