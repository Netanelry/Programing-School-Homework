using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ex
{
    class Mango : FruitBase
    {
        public float _size;
        public bool _isSoft;

        public override bool IsMyFavorite()
        {
            bool isMyfav = false;
            Console.WriteLine("Is this your favorite fruit? (lowercase y or n):");
            string answer = Console.ReadLine();
            if (answer.Equals("y"))
            {
                isMyfav = true;
            }
            return isMyfav;
        }

        public override string ToString()
        {
            string s = "";
            if (_isSoft)
            {
                s = "soooo juicy....";
            }
            else
            {
                s = "not soft";
            }
            return base.ToString() + $" size: {_size} and is {s}";
        }
    }
}
