using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HW
{
    internal class HeroesTable<T> where T : class
    {
        public T[] heroes { get; set; }

        public T this [ int index]
        {
            get
            {
                if (HeadCount() == 0)
                    return default(T);
                else if (index <= heroes.Length-1)
                {
                    if (heroes[index] == null)
                    {
                        for (int i = index - 1; i >= 0; i--)
                        {
                            if (heroes[i] != null)
                                return heroes[i];
                        }
                        return default(T);
                    }
                        else
                            return heroes[index];
                }
                else
                {
                    return heroes[index % heroes.Length - 1];
                }
            }
            set
            {
                heroes[index] = value;
            }
        }

        public HeroesTable(int KnightsSize)
        {
            heroes = new T[KnightsSize];
        }

        public void Delete(int index)
        {
            heroes[index] = default(T);
        }

        public int HeadCount()
        {
            int counter = 0;
            for (int i = 0; i < heroes.Length; i++)
            {
                if (heroes[i] != null)
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

            foreach (T knight in heroes)
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
            heroes[index] = knight;
        }
    }
}
