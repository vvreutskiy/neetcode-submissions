public class MyStack {
    private Queue<int> _data = new();
    private Queue<int> _temp = new();
    private int? _lastPushed = null;

    public MyStack() {}

    public void Push(int x) {
        _data.Enqueue(x);
        _lastPushed = x;
    }

    public int Pop() {
        return reloadExceptLast();
    }

    public int Top() {
        return _lastPushed ?? -1;
    }

    public bool Empty() {
        return _data.Count == 0;
    }

    private int reloadExceptLast() {
        var size = _data.Count;
        for (int i = 0; i < size - 1; i++) {
            var element = _data.Dequeue();
            _temp.Enqueue(element);
            if (i == size - 2)
                _lastPushed = element;
        }
        (_temp, _data) = (_data, _temp);
        return _temp.Dequeue();
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */