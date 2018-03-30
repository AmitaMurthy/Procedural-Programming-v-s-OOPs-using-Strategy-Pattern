using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemB
{
    class SubArray : Strategy
    {

        private readonly int firstIndex;
        protected int lastIndex;

        public SubArray(int f, int l)
        {
            firstIndex = f;
            lastIndex = l;

        }

        public SubArray(int f)
        {
            firstIndex = f;
            lastIndex = f;

        }

        public virtual int[] Process(int[] array)
        {
            int[] newArray = new int[lastIndex - firstIndex + 1];
            int count = firstIndex;

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[count];
                count++;
            }
            return newArray;
        }

        public override string ToString()
        {
            return $"Subarray of the Array[{firstIndex}] to Array[{lastIndex}]";
        }
    }
}
