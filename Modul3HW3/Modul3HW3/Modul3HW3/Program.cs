using System;

namespace Modul3HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var result = new Class2();
            var show = new Class1.SomeDel(Show);
            var myClass2Del = new Class2.MyOwnDelegate(Class1.Pow);
            var myDel = result.Calc(2, 3, myClass2Del);
            show.Invoke(myDel.Invoke(2));
        }

        public static void Show(bool x)
        {
            Console.WriteLine(x);
        }
    }
}
