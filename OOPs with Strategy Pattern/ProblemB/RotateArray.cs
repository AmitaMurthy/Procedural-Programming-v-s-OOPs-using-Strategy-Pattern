using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemB
{
    class RotateArray : Strategy
    {
        private readonly bool rotatedLeft;

        public RotateArray(bool r)
        {
            rotatedLeft = r;
        }
        
        public virtual int[] Process(int[] array)
        {
            int temp;

            if (rotatedLeft)
            {
                temp = array[0];

                for (int i = 1; i < array.Length; i++)
                {
                    array[i - 1] = array[i];
                }
                array[array.Length - 1] = temp;
            }
            else
            {
                temp = array[array.Length - 1];

                for (int i = array.Length - 2; i >= 0; i--)
                {
                    array[i + 1] = array[i];
                }
                array[0] = temp;
            }

            return array;
        }

        public override string ToString()
        {
            string flag = (rotatedLeft == true ? "left" : "right");
            return $"Rotated an array {flag} by 1 place";
        }
    }
}
