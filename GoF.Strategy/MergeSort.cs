using System;
using System.Collections.Generic;

namespace GoF.Strategy
{
    /// <summary>
    /// A 'Concrete MergeSort Strategy' class
    /// </summary>
    class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Merge_Sort(list);
        }

        private void Merge_Sort(List<string> list)
        {
            List<string> left;
            List<string> right;
            
            //As this is a recursive algorithm, we need to have a base case to 
            //avoid an infinite recursion and therfore a stackoverflow
            if (list.Count <= 1)
                return;
            // The exact midpoint of our array  
            int midPoint = list.Count / 2;
            //Will represent our 'left' array
            left = new List<string>();
            right = new List<string>();

            //populate left array
            for (int i = 0; i < midPoint; i++)
                left.Add(list[i]);

            //populate right array
            //We start our index from the midpoint, as we have already populated the left array from 0 to midpont
            for (int i = midPoint; i < list.Count; i++)
                right.Add(list[i]);

            //Recursively sort the left array
            Merge_Sort(left);
            //Recursively sort the right array
            Merge_Sort(right);
            //Merge our two sorted arrays
            Merge(list, left, right);
        }

        //This method will be responsible for combining our two sorted arrays into one giant array
        private void Merge(List<string> list, List<string> left, List<string> right)
        {
            int resultLength = right.Count + left.Count;

            //
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            //while either array still has an element
            while (indexLeft < left.Count || indexRight < right.Count)
            {
                //if both arrays have elements  
                if (indexLeft < left.Count && indexRight < right.Count)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (left[indexLeft].CompareTo(right[indexRight]) <= 0)
                    {
                        list[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // else the item in the right array wll be added to the results array
                    else
                    {
                        list[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                //if only the left array still has elements, add all its items to the results array
                else if (indexLeft < left.Count)
                {
                    list[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                //if only the right array still has elements, add all its items to the results array
                else if (indexRight < right.Count)
                {
                    list[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
        }
    }
}
