public class MinStack
{
    private Stack<int> _totalStack;
    private Stack<int> _minStack;

    public MinStack()
    {
        _totalStack = new();
        _minStack = new();
    }

    public void Push(int val)
    {
        _totalStack.Push(val);
        if (!_minStack.TryPeek(out var currentMin) || val <= currentMin)
            _minStack.Push(val);
    }

    public void Pop()
    {
        var popped = _totalStack.Pop();
        if (popped == _minStack.Peek())
            _minStack.Pop();
    }

    public int Top()
    {
        return _totalStack.Peek();
    }

    public int GetMin()
    {
        return _minStack.TryPeek(out var result) ? result : 0;
    }
}