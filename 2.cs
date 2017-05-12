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
            long sum = 0;
            int pos = 1;
            while (FibonaciInPositionNth(pos) < 4000000)
            {
                if (FibonaciInPositionNth(pos) % 2 == 0)
                    sum += FibonaciInPositionNth(pos);
                pos++;
            }
            Console.WriteLine("{0}", sum);
            Console.ReadLine();
        }
        static int FibonaciInPositionNth(int pos)
        {
            if (pos == 1) return 1;
            if (pos == 2) return 2;
            return FibonaciInPositionNth(pos - 1) + FibonaciInPositionNth(pos - 2);
        }
    }
}
