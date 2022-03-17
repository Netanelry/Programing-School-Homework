using System;

namespace Lesson2022_03_10
{
    internal class Program
    { 
    static void Main(string[] args)
        {
            GenericLinkedList<int> gllInt = new GenericLinkedList<int>();
            gllInt.InsertFront(13);
            gllInt.InsertLast(22);
            gllInt.InsertLast(122);

            GenericLinkedList<bool> gllBool = new GenericLinkedList<bool>();
            gllBool.InsertFront(false);

            GenericLinkedList<Book> gllBook = new GenericLinkedList<Book>();
            gllBook.InsertFront(new Book());

            GenericType<float> gc = new GenericType<float>();
            gc.PrintType(3.7f);
            //gc.PrintType("muki"); //error
            gc.WriteLine(true);
        }
    }
}