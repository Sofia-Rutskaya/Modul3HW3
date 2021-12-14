using System;

namespace Modul3HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var result = new Class2();
            var show = new Class1();
            show.SomeDel = Show;
            show.SomeDel(result.Calc(show.Pow, 3, 5).Invoke(4));
        }

        public static void Show(bool x)
        {
            Console.WriteLine(x);
        }
    }
}
