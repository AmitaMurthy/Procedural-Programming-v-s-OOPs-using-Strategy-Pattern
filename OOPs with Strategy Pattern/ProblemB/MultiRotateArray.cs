using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemB
{
    class MultiRotateArray : RotateArray
    {
        private readonly int n;

        public MultiRotateArray(int num) : base(num>0?true:false)
        {
            n = num;

        }

       

        public override int[] Process(int[] array)
        {
            
            int m = n;
            if(m<0)
            {
                m = -1 * m;
            }


            for (int i = 0; i < m; i++)
            {
                array = base.Process(array);
                

            }





            return array;

        }

        public override string ToString()
        {
            string flag = n > 0 ? "left" : "right";
            return $"Rotated an array {flag} by {Math.Abs(n)} places";
        }

    }
}
