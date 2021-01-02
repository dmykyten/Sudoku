using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Validator
    {
        Board board;
        public Validator(Board board)
        {
            this.board = board;
        }

        public bool IsValid()
        {
            bool valid = IsValidVertically() &&
                         IsValidHorizontally() &&
                         IsValidInTile();
            return valid;
        }

        bool IsValidVertically()
        {
            return true;
        }
        bool IsValidHorizontally()
        {
            return true;
        }
        bool IsValidInTile()
        {
            return true;
        }

    }
}
