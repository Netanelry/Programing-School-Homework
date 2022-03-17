using System;
using System.Collections;

namespace CC_SimpleStructures_Lesson2022_03_03
{
    internal class StringArrayList
    {
        private ArrayList messages;

        //create indexer (return string) with get and set
        //create overload indexer (accept int[] return string[]) with get and set
        
        //public ?? this[int index]
        //{
        //    get
        //    {
        //        return ??;
        //    }
        //    set
        //    {
        //        ?? = value;
        //    }
        //}

        public void Add(string newMessage)
        {
            messages.Add(newMessage);
        }

        //create addRange method
        public void AddRange(string[] newMessage)
        {
            messages.AddRange(newMessage);
        }

        //create insert method
        public void Insert(int index, string newMessage)
        {
            messages.Insert(index, newMessage);
        }

        //create insertRange method
        public void InsertRange(int index, string[] newMessages)
        {
            messages.InsertRange(index, newMessages);
        }

        //create remove method
        public void Remove(string newMessage)
        {
            messages.Remove(newMessage);
        }
        //create removeRange method
        public void RemoveRange(int fromIndex, int count)
        {
            messages.RemoveRange(fromIndex, count);
        }

        //create getByIndex method

        //create getAll method
        public string[] GetAll()
        {
            return (string[]) messages.Clone();
        }

    }
}
