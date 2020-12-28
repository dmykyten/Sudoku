using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class NumberCell : Cell
    {
        public int Value { get; private set; }

        public override bool isEmpty { get { return false; } }

        public NumberCell(int number)
        {
            Value = number;
        }

        public override string ToString()
        {
            return $"NumberCell({Value})";
        }
    }
}
