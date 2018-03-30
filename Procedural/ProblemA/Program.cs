using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] newArray = CopyArray(array);
            newArray = MultiRotateArray(newArray, -4);
            newArray = SubArray(newArray, 3, 6);
            newArray = RotateArray(newArray, true);
            newArray = SubArray(newArray, 0, 0);

            Console.WriteLine(string.Join(" ", newArray));
        }

        static int[] SubArray(int[] array, int firstIndex, int lastIndex)
        {
            int[] newArray = new int[lastIndex-firstIndex+1];

            for(int i=0; i<newArray.Length; i++)
            {
                newArray[i] = array[firstIndex];
                firstIndex++;
            }
            return newArray;
        }

        static int[] CopyArray(int[] array)
        {
            int[] newArray = SubArray(array, 0, array.Length - 1);

            return newArray;
        }

        static int[] RotateArray(int[] array, bool rotatedLeft)
        {
            
            int temp;

            if(rotatedLeft)
            {
                temp = array[0];

                for(int i=1; i<array.Length; i++)
                {
                    array[i - 1] = array[i];
                }
                array[array.Length-1] = temp;
            }
            else
            {
                temp = array[array.Length-1];

                for(int i=array.Length-2; i>=0; i--)
                {
                    array[i + 1] = array[i];
                }
                array[0] = temp;
            }
            
            return array;
        }

        static int[] MultiRotateArray(int[] array, int n)
        {
            if(n>0)
            {
                for(int i=0; i<n; i++)
                {
                    array = RotateArray(array, true);
                    
                }
            }
            else
            {
                for (int i = 0; i < (-1*n); i++)
                {
                    array = RotateArray(array, false);
                }
            }


            return array;
        }
    }
}
