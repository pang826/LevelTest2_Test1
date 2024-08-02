using System.Collections.Specialized;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iLeft = 10;
            int iRight = 20;
            Util.Swap(ref iLeft, ref iRight);
            Console.WriteLine("int 자료형을 사용한 Swap 함수");
            Console.WriteLine($"{iLeft},{iRight}");

            Console.WriteLine();

            double dLeft = 3.5;
            double dRight = 8.8;
            Util.Swap(ref dLeft, ref dRight);
            Console.WriteLine("double 자료형을 사용한 Swap 함수");
            Console.WriteLine($"{dLeft},{dRight}");
        }
        public class Util
        {
            static public void Swap<T>(ref T a, ref T b) where T : struct
            {
                T temp = a;
                a = b;
                b = temp;
            }
        }
    }

    
}
