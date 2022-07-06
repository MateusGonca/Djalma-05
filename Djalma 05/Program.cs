using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djalma_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            for (n=1; n<=100; n++)
                if(n%2 ==0)
                {
                    Console.WriteLine(n);
                    }
            Console.ReadKey();
        }
    }
}
