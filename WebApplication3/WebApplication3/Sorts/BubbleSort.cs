using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebApplication3.Sorts
{
    public class BubbleSort<T> where T : IComparable<T>
    {
        public void Sort(T[] items)
        {
            bool swapped; int compare = 0; int swap = 0;
            DateTime dateTime1 = DateTime.Now;
            do
            {
                swapped = false;
                for (int i = 0; i < items.Length; i++)
                {
                    compare = compare + 1;
                    if ((i + 1 < items.Length) && items[i].CompareTo(items[i + 1]) > 0)
                    {
                        swap = swap + 1;
                        Swap(items, i, i + 1);
                        swapped = true;
                    }
                }
            }
            while (swapped != false);
            DateTime dateTime2 = DateTime.Now;
            var diffInSeconds = (dateTime2 - dateTime1).TotalSeconds;
        }

        private void Swap(T[] items, int left, int right)
        {
            if (left != right)
            {
                T temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }
    }
}