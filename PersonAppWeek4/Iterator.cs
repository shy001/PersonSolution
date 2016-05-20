using PersonSolution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonAppWeek4
{
    interface Iterator<T>
    {
        bool HasNext();

        T Next();
    }
}
