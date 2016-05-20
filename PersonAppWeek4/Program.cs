using PersonSolution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAppWeek4
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList<Person>();
            linkedList.AddLast(new Person(1,"Tim3"));
            linkedList.AddLast(new Person(1, "Tim5"));
            linkedList.AddLast(new Person(1, "Tim2"));
            linkedList.AddLast(new Person(1, "Tim10"));
            linkedList.AddLast(new Person(1, "Tim7"));
            linkedList.AddLast(new Person(1, "Tim9"));

            var linkedListIterator = new LinkedListIterator<Person>(linkedList);

            while (linkedListIterator.HasNext())
            {
                Console.WriteLine(linkedListIterator.Next());
            }

            Console.WriteLine();

            //var descLinkedListIterator = new DescLinkedListIterator(linkedList);
                     


            Console.ReadKey();
        }
    }
}
