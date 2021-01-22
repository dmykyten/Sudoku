using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class NumberCell : Cell
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

        public override int GetHashCode()
        {
            return Value;
        }

        public override bool Equals(object obj)
        {

            return obj != null && obj.GetType() == GetType() && ((NumberCell)obj).Value == Value;
        }
    }
}
