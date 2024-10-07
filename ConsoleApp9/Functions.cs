using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Functions
    {
        public int[] items;
        public int count;


        public Functions()
        {
            items = new int[4];
            count = 0;
        }


        public int Count => count;


        public int Capacity => items.Length;

        public void ResizeArray(int newSize = -1)
        {
            int newCapacity = newSize == -1 ? items.Length * 2 : newSize;
            int[] newArray = new int[newCapacity];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = items[i];
            }
            items = newArray;
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i] == item)
                    return i;
            }
            return -1;
        }

        public void Add(int item)
        {
            if (count == items.Length)
                ResizeArray();
            items[count++] = item;
        }


        public void AddRange(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Add(array[i]);
            }
        }


        public void Insert(int index, int item)
        {


            if (count == items.Length)
                ResizeArray();


            for (int i = count; i > index; i--)
            {
                items[i] = items[i - 1];
            }

            items[index] = item;
            count++;
        }


        public void InsertRange(int index, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Insert(index + i, array[i]);
            }
        }


        public bool Remove(int item)
        {
            int index = IndexOf(item);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }
            return false;
        }


        public int RemoveAll(Predicate<int> match)
        {
            int removedCount = 0;
            for (int i = 0; i < count; i++)
            {
                if (match(items[i]))
                {
                    RemoveAt(i);
                    i--; 
                    removedCount++;
                }
            }
            return removedCount;
        }


        public void RemoveAt(int index)
        {


            for (int i = index; i < count - 1; i++)
            {
                items[i] = items[i + 1];
            }

            items[--count] = 0;
        }


        public void Clear()
        {
            for (int i = 0; i < count; i++)
            {
                items[i] = 0;
            }
            count = 0;
        }


        public void Sortt(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {

                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }


        public void Reverse()
        {
            for (int i = 0; i < count / 2; i++)
            {
                int temp = items[i];
                items[i] = items[count - i - 1];
                items[count - i - 1] = temp;
            }
        }


        public void TrimExcess()
        {
            if (count < items.Length)
            {
                ResizeArray(count);
            }
        }
    }
}