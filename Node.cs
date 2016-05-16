﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
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
}
