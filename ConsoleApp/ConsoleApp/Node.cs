﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node()
        {
        }
        public Node(int value)
        {
            this.Value = value;
            Next = null;
        }
    }
}
