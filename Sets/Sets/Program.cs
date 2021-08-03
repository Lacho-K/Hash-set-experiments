using System;
using System.Collections.Generic;

namespace Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            for (int i = 0; i < n ; i++)
            {
                string curName = Console.ReadLine();
                names.Add(curName);
            }
            Console.WriteLine(String.Join('\n',names));
        }
    }
}
