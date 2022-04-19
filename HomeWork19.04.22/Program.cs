using System;

namespace HomeWork19._04._22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 8, 49, 17, 5 };
            Array.Sort(array);
            int MaxValue = array[array.Length - 1];
            Console.WriteLine(MaxValue);

        }
    }
}
