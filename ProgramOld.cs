using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class ProgramOld
    {

        static void Main(string[] args)
        {
            var p1 = new Person(12, "Stevo");
            var p2 = new Person(99, "Darryn");
            var p3 = new Person(37, "Mo");

            var n1 = new Node<Person>(p1);
            var n2 = new Node<Person>(p2);
            var n3 = new Node<Person>(p3);

            n1.Next = n2;
            n1.Previous = n1;
            n2.Next = n3;
            n2.Previous = n1;
            n3.Previous = n2;
            
            var linkedList = new KcLinkedList<Person>();
            linkedList.Add(p1);
            linkedList.Add(p2);
            linkedList.Add(p3);

            Console.WriteLine(linkedList.Display());
            //foreach (var person in linkedList)
            //{
            //    Console.WriteLine(person);
            //}

            //foreach (var person in linkedList.linkedListInReverse)
            //{
            //    Console.WriteLine(person);
            //}
            Console.ReadKey();
        }
    }

    public class KcLinkedList<T> : IEnumerable<T>
    {
        private Node<T> _root;
        private Node<T> _last;
        private Node<T> _previous;

        public void Add(T value)
        {
            if (_root == null)
            {
                //First
                _root = new Node<T>(value);
               // _previous = _root;
                _last = _root;
            }
            else
            {
                //Following Nodes
                var newValue = new Node<T>(value);
                if (_previous == null)
                {
                    _previous = _root;
                }
                else
                {
                    _previous = _last;
                }
                _last = newValue;
                _last.Next = newValue;
                _previous.Next = newValue;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            var element = _root;
            while (element != null)
            {
                yield return (element.Data);

                element = element.Next;
                element = element.Previous;
            }           
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<T> linkedListInReverse
        {
            //get
            //{
            //    var element = _last;
            //    while (element != _root)
            //    {
            //        //var newValue = new Node<T>(element);
            //        //_last.Next = newValue;
            //        //_last = newValue;
            //        //element = element.Next;
            //        //yield return (element.Data);
            //        yield return (element.Data);
            //        //var newValue = new Node<T>(element);
            //        //_last.Next = newValue;
            //        //_last = newValue;
            //        element = element.Previous;
            //    }
            //}
            get
            {
                var element = _root;
                while (element != null)
                {
                    yield return (element.Data);

                    element = element.Next;
                    element = element.Previous;
                }
            }
        }

        public string Display()
        {
            var resultString = "";
            var element = _root;
            while (element != null)
            {
                resultString += element + ", ";

                element = element.Next;
            }

            return resultString;
        }
    }


    public class Node<T>
    {

        public Node(T value)
        {
            Data = value;
        }

       public  T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }

        public override string ToString()
        {
            return Data.ToString();
        }
    }

    public class Person
    {
        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public int Age { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}", Name, Age);
        }
    }

}
