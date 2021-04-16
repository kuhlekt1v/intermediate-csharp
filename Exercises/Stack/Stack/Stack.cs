using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stack
    {
        private readonly List<object> _stackList = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Can't place nulls on the stack.");

            _stackList.Add(obj);
        }

        public object Pop()
        {
            if(_stackList.Count == 0)
                throw new InvalidOperationException("Nothing to remove, stack is empty!");

            var lastValue = _stackList.Count - 1;
            var returnItem = _stackList [lastValue];
            _stackList.RemoveAt(lastValue);

            return returnItem;
        }

        public string Clear()
        {
            var count = _stackList.Count;
            if (count == 0)
                return "No items in the stack!";

            _stackList.Clear();
            return $"{count} items removed from stack.";
        }
    }

    
}
