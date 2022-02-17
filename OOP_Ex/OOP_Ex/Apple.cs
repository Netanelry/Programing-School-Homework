using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ex
{
    class Apple : FruitBase
    {
        public string _color;
        public bool _isPinkLady;

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
            string PL = "";
            if (_isPinkLady)
            {
                PL = "is a Pink Lady";
            }
            else
            {
                PL = "is not a Pink Lady";
            }

            return base.ToString() + "," + $" it's color is{_color}, and " + PL;
        }
    }
}
