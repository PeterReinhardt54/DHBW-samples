using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.IteratorMP3
{
    public class RandomIterator<T> : Iterator<T>
    {
        private int actualPos;
        private List<T> list;
        private List<T> randomList;

        public RandomIterator(List<T> list)
        {
            this.list = list;
            start();
        }

        public void start()
        {
            randomList = new List<T>(list);

            Random rnd = new Random();
            int n = randomList.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                T value = randomList[k];
                randomList[k] = randomList[n];
                randomList[n] = value;
            }

            actualPos = -1;
        }

        public void next()
        {
            if (!isFinished())
                actualPos++;
        }

        public bool isFinished()
        {
            return actualPos >= (randomList.Count - 1);
        }

        public T actual()
        {
            if (actualPos == -1)
                return default(T);
            return randomList[actualPos];
        }

        public void iterate(Action<T> action)
        {
            while (!isFinished())
            {
                next();
                action(actual());
            }
        }
    }
}
