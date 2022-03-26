using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_List_HW
{
    internal class MyLibrary : IDictManagment<string, Book>
    {
        private Dictionary<string, Book> books;

        public int Count { get => books.Count; }

        public MyLibrary()
        {
            books = new Dictionary<string, Book>();
        }
        
        /*this is HaveThisBook From homework
        but I implemented it in a more generic way*/
        public bool isValueExist(string key)
        {
            return books.ContainsKey(key);
        }

        public bool Add(Book value)
        {
            if (value == null)
            {
                return false;
            }
            return books.TryAdd(value.Title, value);
        }

        public void Delete(string key)
        {
            books.Remove(key);
        }
        public void Clear()
        {
            books = new Dictionary<string, Book>();
        }

        public void Update(string key, Book value)
        {
            books[key] = value;
        }

        public Book Get(string key)
        {
            return books[key];
        }

        public List<Book> GetAll()
        {
            return books.Values.ToList();
        }

        public List<string> GetAllAuthors()
        {
            List<string> authors = new List<string>();
            foreach (Book book in books.Values)
            {
                authors.Add(book.Author);
            }
            return authors;
        }

        public List<Book> GetBooksSortedByAuthorName()
        {
            return books.Values.OrderBy(book => book.Author).ToList();
        }

        public override string ToString()
        {
            string res = "";
            foreach (KeyValuePair<string, Book> book in books)
            {
                res += book.Key + " : " + book.Value + "\n";
            }
            return res;
        }
    }
}
