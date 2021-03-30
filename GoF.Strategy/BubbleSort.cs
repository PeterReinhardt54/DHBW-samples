using System;
using System.Collections.Generic;

namespace GoF.Strategy
{
    class BubbleSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Bubble_Sort(list);
        }

        private void Bubble_Sort(List<string> list)
        {
            string temp;

            for (int p = 0; p <= list.Count - 2; p++)
            {
                for (int i = 0; i <= list.Count - 2; i++)
                {
                    if (list[i].CompareTo(list[i + 1]) > 0)
                    {
                        temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                    }
                }
            }
        }
    }
}
