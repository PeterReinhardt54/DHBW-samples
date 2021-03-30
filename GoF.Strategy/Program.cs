using System;

namespace GoF.Strategy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Two contexts following different strategies
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            Console.WriteLine("vor QuickSort");
            studentRecords.Show();
            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();
            studentRecords.Show();

            studentRecords.Shuffle();
            Console.WriteLine("vor ShellSort");
            studentRecords.Show();
            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();
            studentRecords.Show();

            studentRecords.Shuffle();
            Console.WriteLine("vor MergeSort");
            studentRecords.Show();
            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();
            studentRecords.Show();

            studentRecords.Shuffle();
            Console.WriteLine("vor BubbleSort");
            studentRecords.Show();
            studentRecords.SetSortStrategy(new BubbleSort());
            studentRecords.Sort();
            studentRecords.Show();

            studentRecords.Shuffle();
            Console.WriteLine("vor InsertionSort");
            studentRecords.Show();
            studentRecords.SetSortStrategy(new InsertionSort());
            studentRecords.Sort();
            studentRecords.Show();

            // Wait for user
            Console.ReadKey();
        }
    }
}
