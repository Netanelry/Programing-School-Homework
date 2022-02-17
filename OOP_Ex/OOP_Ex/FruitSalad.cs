using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ex
{
    class FruitSalad
    {
        public FruitBase[] _fruits;

        public int GetTotalCalories()
        {
            int cal = 0;
            foreach (FruitBase fruit in _fruits)
            {
                cal += fruit._calories;
            }
            return cal;
        }

        public bool isHaveFavoriteFruit()
        {
            bool isContain = false;
            foreach (FruitBase fruit in _fruits)
            {
                if (fruit.IsMyFavorite())
                {
                    isContain = true;
                }
            }
            return isContain;
        }

        public override string ToString()
        {
            string allfruits = "";
            foreach (FruitBase fruit in _fruits)
            {
                allfruits += fruit + "/n";
            }
            return allfruits;
        }
    }
}
