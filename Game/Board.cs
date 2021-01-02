using System;

namespace Game
{
    public class Board
    {
        public const int SIZE = 9;
        public Cell[,] Cells { get; private set; } = new Cell[SIZE,SIZE];
        public Board(string[] lines)
        {
            for(int i = 0; i != lines.Length; i++)
            {
                
                for(int j = 0; j != lines[i].Length; j++)
                {
                    if(lines[i][j] >= 49 && lines[i][j] <= 57)
                    {
                        int number = int.Parse(lines[i][j].ToString());
                        Cells[i, j] = new NumberCell(number);
                    }
                    else
                    {
                        Cells[i, j] = new VariantCell();
                    }
                }
            }
        }
        public bool IsValid()
        {   
            return new Validator(this).IsValid();
        }
    }
}
