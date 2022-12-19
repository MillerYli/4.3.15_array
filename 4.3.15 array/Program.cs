using System;

namespace mynamespase
{
    class program
    {
        public static void Main(string[] args)
        {
            var arr = new int[] { 8, 9, 6, 0, 8, 4, 2 };

            int count = 0;

            foreach(int i in arr)
            {
                count++;
            }
            Console.WriteLine("Кол-во элементов в массиве: {0}", count);
        }
    }
}
