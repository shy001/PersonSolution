using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorSessionWeek1.Cmd
{
    class Program
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
            n2.Next = n3;
            n2.Previous = n1;
            n3.Previous = n2;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);

            var linkedList = new KcLinkedList<Person>();
            linkedList.Add(p1);
            linkedList.Add(p2);
            linkedList.Add(p3);


            Console.WriteLine(linkedList.Display());
            Console.WriteLine(linkedList.InReverse());

            while (linkedList.hasNext())
            {
                Console.WriteLine(linkedList.next());
            }

            Console.ReadKey();
        }
    }

    public class KcLinkedList<T>
    {
        private Node<T> _root;
        private Node<T> _last;
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


    public class Node<T>
    {

        public Node(T value)
        {
            Data = value;
        }

        T Data { get; set; }
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
