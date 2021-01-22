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
            var set = new HashSet<Cell>();
            for (int x = 0; x < Board.SIZE; x++)                //iterating by x
            {
                for (int y = 0; y < Board.SIZE; y++)        //iterating by y
                {
                    if (board.Cells[y, x].isEmpty == true)      //validating compared cell by type
                    {
                        continue;
                    }
                    if (set.Contains(board.Cells[y, x]) == true)                        //comparing cells
                    {
                        return false;
                    }
                    set.Add(board.Cells[y, x]);
                }
                set.Clear();
            }
            return true;
        }

        bool IsValidHorizontally()
        {
            var set = new HashSet<Cell>();
            for (int y = 0; y < Board.SIZE; y++)                //iterating by x
            {
                for (int x = 0; x < Board.SIZE; x++)        //iterating by y
                {
                    if (board.Cells[y, x].isEmpty == true)      //validating compared cell by type
                    {
                        continue;
                    }
                    if (set.Contains(board.Cells[y, x]) == true)                        //comparing cells
                    {
                        return false;
                    }
                    set.Add(board.Cells[y, x]);
                }
                set.Clear();
            }
            return true;
        }

        bool IsValidInTile()
        {
            var set = new HashSet<Cell>();
            var bound = 3;
            Cell comparedCell;
            for (int tileY = 0; tileY < bound; tileY++)
            {
                for (int tileX = 0; tileX < bound; tileX++)
                {
                    for (int y = 0; y < bound; y++)
                    {
                        for (int x = 0; x < bound; x++)        
                        {
                            comparedCell = board.Cells[(y + bound * tileY), (x + bound * tileX)];
                            
                            if (comparedCell.isEmpty == true)      //validating compared cell by type
                            {
                                continue;
                            }
                            
                            if (set.Contains(comparedCell) == true)                        //comparing cells
                            {
                                return false;
                            }
                            set.Add(comparedCell);
                        }
                    }
                    set.Clear();
                }
            }
            return true;
        }

        /*bool IsValidVertically()
          {
              var cellX = 0;
              var cellY = 0;
              var areEqual = false;
              do
              {
                  for (int x = cellX; x < Board.SIZE; x++)                //iterating by x
                  {
                      if (board.Cells[cellY, cellX].isEmpty != true )     //validating main cell by type
                      {
                          for (int y = cellY; y < Board.SIZE; y++)        //iterating by y
                          {
                              if (board.Cells[y, x].isEmpty == true)      //validating compared cell by type
                              {
                                  continue;
                              }
                              areEqual = (cellY != y || cellX != x) && ((NumberCell)board.Cells[cellY, cellX]).Value == ((NumberCell)board.Cells[y, x]).Value;
                              if(areEqual == true)                        //comparing cells
                              {
                                  return false;
                              }
                          }
                      }
                      cellX++;
                  }
                  cellY++;
                  cellX = 0;
              } while (cellX < Board.SIZE - 1 && cellY < Board.SIZE - 2);
              return true;
          }*/

    }
}
