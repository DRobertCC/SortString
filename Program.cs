using System;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "Microsoft .NET Framework 2.0 Application Development Foundation";
            string str = "Q W E R T Z U I O P A S D F G H J K L Y X C V B N M 9 5 1 7 3 8 4 6 2 0";
            string[] words = str.Split(' ');

            Array.Sort(words);

            String s = String.Join(" ", words);

            Console.WriteLine("Original string: {0}", str);
            Console.WriteLine("Sorted string:   {0}", s);
            Console.ReadKey();
        }
    }
}
