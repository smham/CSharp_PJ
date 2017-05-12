using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int index = 3; index < 1000; index++)
                if (index % 3 == 0 || index % 5 == 0)
                    sum += index;
            Console.WriteLine("{0}", sum);
            Console.ReadLine();
        }
    }
}
