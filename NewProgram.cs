using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class NewProgram
    {
        static void Main(string[] args)
        {
            KcLinkedList<Person> linkedlist = new KcLinkedList<Person>();
            linkedlist.Add(new Person(5, "Steveo"));
            linkedlist.Add(new Person(6, "Divan"));
            linkedlist.Add(new Person(7, "Dan"));

            foreach (string x in linkedlist.GetEnumerator())
            {
                Console.WriteLine(x);
            }
            //Console.WriteLine(linkedlist.ReverseIterator());
            Console.ReadLine();
        }
    }
}
