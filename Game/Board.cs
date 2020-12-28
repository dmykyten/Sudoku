using System;

namespace Game
{
    public class Board
    {
        const int SIZE = 9;
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

        //debug purposes
        public string[] AsStrings()
        {
            string[] lines = new string[9];
            for (int i = 0; i != SIZE; i++)
            {
                string line = "";
                for (int j = 0; j != SIZE; j++)
                {
                    if(Cells[i, j].isEmpty == true)
                    {
                        line += ".";
                    }
                    else
                    {
                        line += ((NumberCell)Cells[i, j]).Value;
                    }
                }
                lines[i] = line;
            }
            return lines;
        }
        public static bool IsValid()
        {
            return false;
        }
    }
}
