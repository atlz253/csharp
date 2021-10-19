using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace lab_4_1
{
    static class Program
    {
        static IntPtr arr;

        [DllImport(@"../../../lib/libarray.so")] private static extern IntPtr create();
        [DllImport(@"../../../lib/libarray.so")] private static extern IntPtr zsqr(IntPtr arr);
        [DllImport(@"../../../lib/libarray.so")] private static extern IntPtr print(IntPtr arr);

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Создать массив");
                Console.WriteLine("2. Обработать массив");
                Console.WriteLine("3. Показать массив");
                Console.WriteLine("0. Я больше не могу здесь находиться! Указатели в C#?!?!?!");

                int.TryParse(Console.ReadLine(), out int choice);

                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        arr = create();
                        break;
                    case 2:
                        zsqr(arr);
                        break;
                    case 3:
                        print(arr);
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
