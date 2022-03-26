using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dict_List_HW
{
    internal class Book
    {
        //fields
        string _title;
        string _content;
        string _author;
        string _category;

        //properties
        public string Title
        {
            get { return _title; }
            private set { _title = value; } 
        }
        public string Content
        {
            get { return _content; }
            private set { _content = value; }
        }
        public string Author
        {
            get { return _author; }
            private set { _author = value; }
        }
        public string Category
        {
            get { return _category; }
            private set { _category = value; }
        }

        //constructors
        public Book(string title, string author, string category)
        {
            Title = title;
            Author = author;
            Category = category;
        }
        public Book(string title, string? content, string author, string category)
        {
            Title = title;
            Content = content;
            Author = author;
            Category = category;
        }

        //overrides
        public override string? ToString()
        {
            return JsonSerializer.Serialize(this);
        }

    }
}
