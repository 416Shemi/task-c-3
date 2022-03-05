using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nambers = { 3, 5, 12, 1, 4, 8,-4  };
            int min = nambers[0];
            for (int i = 0; i < nambers.Length; i++)
                if(nambers[i]<min)
            {
                    min = nambers[i];

            }

            {
                Console.WriteLine(min);
                Console.ReadLine();

            }
        }
    }
}
