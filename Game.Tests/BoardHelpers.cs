using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Tests
{
    static class BoardHelpers
    {
        public static string[] AsStrings(this Board board)
        {
            string[] lines = new string[Board.SIZE];
            for (int i = 0; i != Board.SIZE; i++)
            {
                string line = "";
                for (int j = 0; j != Board.SIZE; j++)
                {
                    if (board.Cells[i, j].isEmpty == true)
                    {
                        line += ".";
                    }
                    else
                    {
                        line += ((NumberCell)board.Cells[i, j]).Value;
                    }
                }
                lines[i] = line;
            }
            return lines;
        }
    }
}
