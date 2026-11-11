public class MyQueue {
    private Stack<int> _forward = new();
    private Stack<int> _backward = new();
    private bool _lastWasPop = false;

    public MyQueue() {}

    public void Push(int x) {
        switch (_forward.Count(), _backward.Count()) {
            case (0, 0):
                _forward.Push(x);
                break;
            case (0, _):
                ToForward();
                _forward.Push(x);
                break;
            case (_, 0):
                _forward.Push(x);
                break;
        }
    }

    public int Pop() {
        switch (_forward.Count(), _backward.Count()) {
            case (0, 0):
                throw new InvalidOperationException();
            case (0, _):
                return _backward.Pop();
            case (_, 0):
                ToBackward();
                return _backward.Pop();
            default:
                throw new InvalidOperationException();
        }
    }

    public int Peek() {
        switch (_forward.Count(), _backward.Count()) {
            case (0, 0):
                throw new InvalidOperationException();
            case (0, _):
                return _backward.Peek();
            case (_, 0):
                ToBackward();
                return _backward.Peek();
            default:
                throw new InvalidOperationException();
        }
    }

    public bool Empty() {
        return _forward.Count() == 0 && _backward.Count() == 0;
    }

    private void ToForward() {
        while (_backward.Count() > 0) {
            _forward.Push(_backward.Pop());
        }
    }

    private void ToBackward() {
        while (_forward.Count() > 0) {
            _backward.Push(_forward.Pop());
        }
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */