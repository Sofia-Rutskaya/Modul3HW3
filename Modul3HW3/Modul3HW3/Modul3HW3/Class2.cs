using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW3
{
    public class Class2
    {
        private NewDelegate _newDelegate;
        private static int _item;

        public delegate int MyOwnDelegate(int x, int y);
        public delegate bool NewDelegate(int x);

        public static bool Result(int x)
        {
            if (_item % x == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public NewDelegate Calc(int x, int y, MyOwnDelegate handle)
        {
            _item = handle.Invoke(x, y);
            _newDelegate = Result;
            return _newDelegate;
        }
    }
}
