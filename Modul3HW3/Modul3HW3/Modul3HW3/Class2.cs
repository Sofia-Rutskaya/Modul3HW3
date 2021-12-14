using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW3
{
    public class Class2
    {
        private static int _item;

        public bool Result(int x)
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

        public Predicate<int> Calc(Func<int, int, int> powItem, int x, int y)
        {
            _item = powItem.Invoke(x, y);
            Predicate<int> result = Result;
            return result;
        }
    }
}
