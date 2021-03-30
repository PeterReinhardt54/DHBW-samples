using System;
using System.Collections.Generic;

namespace GoF.Strategy
{
    /// <summary>
    /// A 'Concrete ShellSort Strategy' class
    /// </summary>
    class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Shell_Sort(list, list.Count);
        }

        static void Shell_Sort(List<string> list, int list_size)
        {
            int i, j, inc;
            String temp;

            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < list_size; i++)
                {
                    j = i;
                    temp = list[i];
                    while ((j >= inc) && (list[j - inc].CompareTo(temp) > 0) )
                    {
                        list[j] = list[j - inc];
                        j = (int)(j - inc);
                    }
                    list[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = (int)(inc / 2);
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }
    }
}
