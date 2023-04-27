using System;
using System.Reflection.Metadata.Ecma335;

namespace Modul
{
    internal class Program
    {
        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массиваномер {0}", i + 1 );
                result[i] = Convert.ToInt32(Console.ReadLine());
            }
            return result;
        }
        static int[] SortArray(int[] array, bool IsSort = false)
        {
            var temp = array;
            if(IsSort)
            {
                temp = SortArray(array);
            }
            foreach(var item in temp)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            var array = GetArrayFromConsole();
            var sortedarray = SortArray(array);
        }
    }
}