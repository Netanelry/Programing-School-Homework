using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ex
{
    class Banana : FruitBase
    {
        public bool _hasBlackSpots;
        public bool _isGreen;
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
            string BS = "";
            if (_hasBlackSpots)
            {
                BS = "has black spots";
            }
            else
            {
                BS = "dose not have black spots (yami)";
            }

            string g = "";
            if (_isGreen)
            {
                g = "green";
            }
            else
            {
                g = "is not green";
            }

            return base.ToString() + $" size: {_size} this banana {BS} and is {g}";
        }
    }
}
