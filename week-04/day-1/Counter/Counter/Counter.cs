using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Counter
    {
        public int MyValue { get; private set; } = 10;
    }

    public void Add(int number)
    {
        MyValue += number;
    }
}
