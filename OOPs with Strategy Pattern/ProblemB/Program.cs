using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemB
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 1,3,5,7,2,4,6,8,10};
            int[] array = { 0,1,2,3,4,5,6,7,8,9};
            SubArray a = new SubArray(3, 6);
            CopyArray b = new CopyArray();
            MultiRotateArray c = new MultiRotateArray(-4);
            RotateArray d = new RotateArray(true);
            SubArray e = new SubArray(0);
            Strategy[] x = {b,c,a,d,e};

            Console.WriteLine(string.Join(" ", Strategize(array,x) ));
        }

        static int[] Strategize(int[] array, Strategy[] strategies)
        {
            foreach(Strategy Strategy in strategies)
            {
                array = Strategy.Process(array);
                Console.WriteLine(Strategy.ToString());
            }

            return array;
        }
    }
}
