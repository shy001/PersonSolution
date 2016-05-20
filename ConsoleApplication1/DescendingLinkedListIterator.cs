using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    public class DescendingLinkedListIterator:Iterator2<Person>
    {
        private KcLinkedList<Person> _linkedList; 
        int currentIndex_ = 0;
        int _length = 0;
        private List<object> list;
        public DescendingLinkedListIterator(KcLinkedList<Person> linkedList)
        {
            _linkedList = linkedList;
            list = new List<object>();
            list = linkedList.Cast<object>().AsEnumerable<object>().ToList();
            _length = list.Count;
        }
        
        public bool HasNext()
        {
            return (currentIndex_ < _length);   
        }
      
        public object Next()
        {
            int oldIndex = currentIndex_;
            currentIndex_++;
            return (list[oldIndex]);
        }
    }
}
