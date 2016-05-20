using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    public interface Iterator2<T>
    {
        bool HasNext();
        object Next();
    }
}
