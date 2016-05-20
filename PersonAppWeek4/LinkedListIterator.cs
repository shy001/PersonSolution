using PersonSolution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonAppWeek4
{
    public class LinkedListIterator<T> : Iterator<T>
    {
        private LinkedList<T> _linkedList;
        private int _count { get; set; }
        private LinkedListNode<T> _current { get; set; }

        public LinkedListIterator(LinkedList<T> linkedList)
        {            
            _linkedList = linkedList;
            _current = _linkedList.First;
        }

        public bool HasNext()
        {
            return _current != null;
        }

        public T Next()
        {
            var oldCurrent = _current;
            _current = _current.Next;
            return oldCurrent.Value;
        }

        
    }
}
