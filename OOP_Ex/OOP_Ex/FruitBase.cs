using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ex
{
    public abstract class FruitBase
    {
        public string _name;
        public int _calories;

        public abstract bool IsMyFavorite();

        public override string ToString()
        {
            return $"Fruit name is {_name}, it's have {_calories} calories";
        }
    }

}

