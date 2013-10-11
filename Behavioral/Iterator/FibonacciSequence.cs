using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class FibonacciSequence : IEnumerable<int>
    {
        public int NumberOfValues { get; set; }

        public FibonacciSequence(int numberOfValues)
        {
            NumberOfValues = numberOfValues;
        }

        public IEnumerator<int> GetEnumerator()
        {
          return new FibonacciEnumerator(NumberOfValues);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
