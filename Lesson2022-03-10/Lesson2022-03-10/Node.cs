using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2022_03_10
{
    internal class Node<T>
    {
        internal T data;
        internal Node<T> next;

        public Node(T data)
        {
            this.data = data;
        }
    }
}

