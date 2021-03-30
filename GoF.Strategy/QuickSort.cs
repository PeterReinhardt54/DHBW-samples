using System;
using System.Collections.Generic;

namespace GoF.Strategy
{
    /// <summary>
    /// A 'Concrete QuickSort Strategy' class
    /// </summary>
    class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Quick_Sort(list, 0, list.Count - 1);
            // oder //list.Sort(); // List<> default sorting strategy is Quicksort
        }

        private void Quick_Sort(List<string> list, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(list, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(list, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(list, pivot + 1, right);
                }
            }

        }

        private int Partition(List<string> list, int left, int right)
        {
            String pivot = list[left];
            while (true)
            {

                while (list[left].CompareTo(pivot) < 0)
                {
                    left++;
                }

                while (list[right].CompareTo(pivot) > 0)
                {
                    right--;
                }

                if (left < right)
                {
                    if (list[left] == list[right])
                        return right;

                    String temp = list[left];
                    list[left] = list[right];
                    list[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
