using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HW
{
    internal class Knight
    {
        private string _name;
        private int _lvl;
        private static int _id = 0;
        private double _hp;
        private double _atk;
        private double _def;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Knight(string playerName)
        {
            _name = playerName;
            _lvl = 1;
            _id++;
            _hp = 10;
            _atk = 2;
            _def = 1;
        }
    }
}
