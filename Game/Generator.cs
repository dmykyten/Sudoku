using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Generator
    {
        Board board;
        int filledCells;
        Random randomizer = new Random();
        public Generator(Board board)
        {
            for (int i = 0; i != Board.SIZE; i++)
            {

                for (int j = 0; j != Board.SIZE; j++)
                {
                    board.Cells[i, j] = new VariantCell();
                }
            }
            this.board = board;
        }
        public Board GetBoard(int filledCells)
        {
            this.filledCells = filledCells;
            
            return board;
        }
    }
}
