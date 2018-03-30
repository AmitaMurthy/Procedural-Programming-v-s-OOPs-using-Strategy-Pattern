using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemB
{
    class CopyArray : SubArray
    {
       
        public CopyArray():base(0)
        {

        }
        public override int[] Process(int[] array)
        {
            lastIndex = array.Length - 1;
            int[] newArray = base.Process(array);

            return newArray;
        }

        public override string ToString()
        {
            return $"Copied an array";
        }


    }
}
