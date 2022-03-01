using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    /**
     * 225. Implement Stack using Queues
     * Your MyStack object will be instantiated and called as such:
     * MyStack obj = new MyStack();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Top();
     * bool param_4 = obj.Empty();
     * 
     * 
     * Runtime: 166 ms, faster than 43.71% of C# online submissions for Implement Stack using Queues.
     * Memory Usage: 38.5 MB, less than 75.50% of C# online submissions for Implement Stack using Queues.
     */
    class MyStack
    {
        Queue<int> queue;
        Queue<int> temp;
        public MyStack()
        {
            queue = new Queue<int>();
        }

        public void Push(int x)
        {
            queue.Enqueue(x);
        }

        public int Pop()
        {
            if (Empty()) return -1;
            temp = new Queue<int>();
            while (queue.Count > 1) temp.Enqueue(queue.Dequeue());
            int pop = queue.Dequeue();
            queue = temp;
            return pop;
        }

        public int Top()
        {
            if (Empty()) return -1;
            temp = new Queue<int>();
            while (queue.Count > 1) temp.Enqueue(queue.Dequeue());
            int top = queue.Dequeue();
            temp.Enqueue(top);
            queue = temp;
            return top;
        }

        public bool Empty()
        {
            return queue.Count == 0;
        }
    }
}
