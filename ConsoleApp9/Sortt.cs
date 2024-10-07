using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Sortt
    {
        public Sortt(int[] array) { }
        private int FindMaxIndex(int[] array, int length)
        {
            int maxIndex = 0;
            for (int i = 1; i < length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }


        public int[] Sort(int[] array)
        {
            int length = array.Length;
            int[] newArray = new int[length];

            int[] tempArray = new int[length];
            array.CopyTo(tempArray, 0);

            
            for (int i = 0; i < length; i++)
            {
               
                int maxIndex = FindMaxIndex(tempArray, length - i);
                int maxValue = tempArray[maxIndex];

                newArray[i] = maxValue;
                tempArray[maxIndex] = int.MinValue;
            }

            return newArray;
        }

        

    }
}
