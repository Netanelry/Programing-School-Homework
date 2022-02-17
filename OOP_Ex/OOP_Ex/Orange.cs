using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ex
{
    class Orange : FruitBase
    {
        public float _size;

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
            return base.ToString() + $" size: {_size}";
        }
    }
}
