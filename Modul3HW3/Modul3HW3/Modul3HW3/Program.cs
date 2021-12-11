using System;

namespace Modul3HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var result = new Class2();
            var myDel = new Class1.SomeDel(Show);
            var myClass2Del = new Class2.MyOwnDelegate(Class1.Pow);
            var myClass2NewDel = result.Calc(2, 3, myClass2Del);
            myDel.Invoke(myClass2NewDel.Invoke(2));
        }

        public static void Show(bool x)
        {
            Console.WriteLine(x);
        }
    }
}
