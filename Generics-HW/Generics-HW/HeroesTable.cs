using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HW
{
    internal class HeroesTable<T> where T : class
    {
        public T[] knights { get; set; }

        public T this [ int index]
        {
            get
            {
                if (HeadCount() == 0)
                    return default(T);
                else if (index <= knights.Length-1)
                {
                    if (knights[index] == null)
                    {
                        for (int i = index - 1; i >= 0; i--)
                        {
                            if (knights[i] != null)
                                return knights[i];
                        }
                        return default(T);
                    }
                        else
                            return knights[index];
                }
                else
                {
                    return knights[index % knights.Length - 1];
                }
            }
            set
            {
                knights[index] = value;
            }
        }

        public HeroesTable(int KnightsSize)
        {
            knights = new T[KnightsSize];
        }

        public void Delete(int index)
        {
            knights[index] = default(T);
        }

        public int HeadCount()
        {
            int counter = 0;
            for (int i = 0; i < knights.Length; i++)
            {
                if (knights[i] != null)
                {
                    counter++;
                }
            }
            return counter;
        }

        public T[] Attention()
        {
            T[] attendingKnights = new T[HeadCount()];
            int i = 0;

            foreach (T knight in knights)
            {
                if (knight != null)
                {
                    attendingKnights[i] = knight;
                    i++;
                }
            }
            return attendingKnights;
        }

        public void SetKnight(T knight,  int index)
        {
            knights[index] = knight;
        }
    }
}
