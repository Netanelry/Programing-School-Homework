using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2022_03_10
{
    internal class GenericLinkedList<T>
    {
        internal Node<T> head;

        internal void InsertFront(T newData)
        {
            Node<T> newNode = new Node<T>(newData);
            newNode.next = head;
            head = newNode;
        }

        internal void InsertLast(T newData)
        {
            Node<T> newNode = new Node<T>(newData);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node<T> lastNode = GetLastNode();
            lastNode.next = newNode;
        }

        internal void InsertAfter(Node<T> prevNode, T newData)
        {
            if (prevNode == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            Node<T> new_node = new Node<T>(newData);
            new_node.next = prevNode.next;
            prevNode.next = new_node;
        }

        internal Node<T> GetLastNode()
        {
            Node<T> temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
    }
}
