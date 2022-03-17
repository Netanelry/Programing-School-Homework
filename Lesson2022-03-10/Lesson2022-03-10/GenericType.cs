using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2022_03_10
{
    internal class GenericType<T>
    {
        public void PrintType(T instance)
        {
            Console.WriteLine(instance.GetType());
        }

        public void WriteLine<TMethod>(TMethod value)
        {
            Console.WriteLine(value);
        }

    }
}
