using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_List_HW
{
    internal interface IDictManagment<TKey, Tvalue>
    {
        /*this is HaveThisBook From homework
        but I implemented it in a more generic way*/
        public int Count { get;}
        bool isValueExist(TKey key);
        List<Tvalue> GetAll();
        Tvalue Get(TKey key);
        bool Add(Tvalue value);
        void Update(TKey key, Tvalue value);
        void Delete(TKey key);
        void Clear();

    }
}
