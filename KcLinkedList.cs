using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class KcLinkedList<T> : IEnumerable // : System.Collections.IEnumerable
    {
        private Node<T> _root;
        private static Node<T> _last;
        //ss
        private Node<T> _previous;
        private Node<T> _current;

        public void Add(T value)
        {
            if (_root == null)
            {
                //First
                _root = new Node<T>(value);
                _current = _root;
                _last = _root;
            }
            else
            {
                //Following Nodes
                var newValue = new Node<T>(value);
                newValue.Previous = _last;
                _last.Next = newValue;
                _last = newValue;
                _current = _last;
            }
        }

        public string Display()
        {
            var resultString = "";
            var element = _root;
            while (element != null)
            {
                resultString += element + ", ";

                _current = element;
                element = element.Next;
            }

            return resultString;
        }

        public string InReverse()
        {
            var resultString = "";
            var element = _last;
            while (element != null)
            {
                resultString += element + ", ";

                _current = element;
                element = element.Previous;
            }

            return resultString;
        }

        public  System.Collections.IEnumerator GetEnumerator()
        {
            var element = _last;
            while (element != null)
            {
                yield return element;
                element = element.Previous;
            }
        }
        
        public  IEnumerable<string> ReverseIterator()
        {
            string result = "";
            var element = _last;
            while (element != null)
            {
                result += element + ", ";

                _current = element;
                element = element.Previous;
                yield return result;
            }
            
        }

        public bool hasNext()
        {
            return (_current.Next != null);
        }

        public Node<T> next()
        {
            var current = _current;
            _current = _current.Next;
            return current;
        }
    }
}
