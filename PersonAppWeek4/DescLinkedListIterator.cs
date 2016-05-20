using PersonSolution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonAppWeek4
{
    class DescLinkedListIterator : Iterator<Person>
    {
        private LinkedList<Person> _linkedList;

        public DescLinkedListIterator(LinkedList<Person> linkedList)
        {            
            _linkedList = linkedList;
        }



        public bool HasNext()
        {
            throw new NotImplementedException();
        }

        public Person Next()
        {
            throw new NotImplementedException();
        }
    }
}
