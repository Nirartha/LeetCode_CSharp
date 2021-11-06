using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class MyQueue
    {

        private Stack<int> s1 = null;
        private Stack<int> s2 = null;

        public MyQueue()
        {
            s1 = new Stack<int>();
            s2 = new Stack<int>();
        }

        public void Push(int x)
        {
            s1.Push(x);
        }

        public int Pop()
        {
            while (s1.Count > 0)
                s2.Push(s1.Pop());
            int top = s2.Pop();
            while (s2.Count > 0)
                s1.Push(s2.Pop());
            return top;
        }

        public int Peek()
        {
            while (s1.Count > 0)
                s2.Push(s1.Pop());
            int top = s2.Peek();
            while (s2.Count > 0)
                s1.Push(s2.Pop());
            return top;
        }

        public bool Empty()
        {
            return (s1.Count == 0);
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
}
