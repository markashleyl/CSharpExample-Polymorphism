using System;
namespace PolymorphismApplication
{
    abstract class WoodPlank
    {
        public abstract int area();
    }
    class TwoByFour : WoodPlank
    {
        private int length;
        private int width;
        public TwoByFour(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }
        public override int area()
        {
            Console.WriteLine("Two-By-Four class area :");
            return (width * length);
        }
    }

    class TwoByFourTester
    {
        static void Main(string[] args)
        {
            TwoByFour r = new TwoByFour(4, 2);
            double a = r.area();
            Console.WriteLine("Area: {0}", a);
            Console.ReadKey();
        }
    }
}