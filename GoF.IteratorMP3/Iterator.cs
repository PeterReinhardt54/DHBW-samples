using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.IteratorMP3
{
    public interface Iterator<T>
    {
        void start();
        void next();
        bool isFinished();
        T actual();
        void iterate(Action<T> action);
    }
}
