using System;
using System.Collections.Generic;

namespace GoF.Strategy
{
    class InsertionSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Insertion_Sort(list);

        }

        private void Insertion_Sort(List<string> list)
        {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        if (list[j - 1].CompareTo(list[j]) > 0)
                        {
                            string temp = list[j - 1];
                            list[j - 1] = list[j];
                            list[j] = temp;
                        }
                    }
                }
        }          
    }
}
