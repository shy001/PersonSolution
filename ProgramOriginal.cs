using ConsoleApplication1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
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
            
            var linkedList = new KcLinkedList<Person>();
            linkedList.Add(p1);
            linkedList.Add(p2);
            linkedList.Add(p3);

            //Console.WriteLine(linkedList.Display());
            foreach (var person in linkedList)
            {
                Console.WriteLine(person);
            }

            var descListIterator = new DescendingLinkedListIterator(linkedList);
            
            while (descListIterator.HasNext())
            {
                Console.WriteLine(descListIterator.Next());
            }
            Console.ReadKey();
        }
    }

    public class KcLinkedList<T> : IEnumerable
    {
        private Node<T> _root;
        private Node<T> _last;

        public void Add(T value)
        {
            if (_root == null)
            {
                //First
                _root = new Node<T>(value);
                _last = _root;
            }
            else
            {
                //Following Nodes
                var newValue = new Node<T>(value);
                _last.Next = newValue;
                _last = newValue;
            }
        }


        public IEnumerator GetEnumerator()
        {
            var element = _root;
            while (element != null)
            {
                yield return (element + ", ");

                element = element.Next;
            }           
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
