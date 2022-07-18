using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructues
{
    internal class Arrays
    {
        private int[] array;
        private int count = 0;

        public Arrays(int length) { 
            array = new int[length];
        }

        public void Print() {
            for (int i = 0; i < count; i++) { 
                Console.WriteLine(array[i]);
            }
        }

        public void Insert(int a) {
            //Resize the array if the items reached to the end
            if (array.Length == count) {
                int[] newArray = new int [count * 2];
                for (int i = 0; i < count; i++){
                    newArray[i] = array[i];
                }
                array = newArray;

                
            }
            //Insert items at the end of the array
            array[count++] = a;
        }

        public void removeAt(int index) {
            // Validate the index
            if (index >= 0 && index < count)
            {
                array[index] = 0;
                //Shift the items to the left to fill the hole
                for (int i = index; i < count; i++)
                {
                    array[i] = array[i + 1];
                }
                count--;
            }
            else { 
                throw new IndexOutOfRangeException();
            }
        }

        public int indexOf(int value) {
            for (int i = 0; i < count; i++) {
                if (array[i] == value) { 
                    return i;
                }
            }

            return -1;
        }

        public int max() {
            int maxValue = 0;
            for (int i = 0; i < count; i++) {
                if (array[i] > maxValue) {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }

        public int min()
        {
            int minValue = 10;
            for (int i = 0; i < count; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
            return minValue;
        }

        public int[] reverse() {
            int[] a = new int[count];
            int revCount = 0;
            for(int i = count - 1; i >= 0; i--)
            {
                a[revCount] = array[i];
                revCount++;
            }
            return a;
        }
    }
}
