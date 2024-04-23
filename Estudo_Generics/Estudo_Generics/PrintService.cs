using System;
using System.Collections.Concurrent;
using System.Linq;

namespace Estudo_Generics
{
    internal class PrintService
    {
        private int[] _values = new int[10];
        private int _count = 0;

        public void AddValue(int value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("FULL");
            }
            _values[_count] = value;
            _count++;
        }

        public int First()
        {
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }

            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
