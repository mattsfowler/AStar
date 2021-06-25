using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar
{
    // Should look for a suitable alternative - using linear search and Lists is slow
    class PriorityQueue<T>
    {
        private List<T> queue;
        private List<int> priorities;
        public PriorityQueue()
        {
            queue = new List<T>();
            priorities = new List<int>();
        }

        public void enqueue(T value, int priority)
        {
            int index = 0;
            while (index < queue.Count && priorities[index] < priority)
                index++;
            queue.Insert(index, value);
            priorities.Insert(index, priority);
        }

        public T dequeue()
        {
            T output = queue.FirstOrDefault();
            if (queue.Count > 0)
            {
                queue.RemoveAt(0);
                priorities.RemoveAt(0);
            }
            return output;
        }

        public int Count()
        {
            return queue.Count;
        }
    }
}
