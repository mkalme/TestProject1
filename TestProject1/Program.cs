using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            int offset = 2;

            int j = offset >> 8;
            int k = offset & 255;

            Console.WriteLine(j + " | " + k);

            Console.ReadLine();
        }
    }
}
