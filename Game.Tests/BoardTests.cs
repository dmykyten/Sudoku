using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Game.Tests
{
    class BoardTests
    {
        [Test]
        public void ConstructorStringArray()
        {
            var validSudoku = TestsHelpers.GetBoardContent("Boards\\BoardValid.txt");
            Board board = new Board(validSudoku);
            foreach (var value in board.AsStrings())
            {
                Console.WriteLine(value);
            }
            Assert.AreEqual(validSudoku, board.AsStrings());
        }
    }
}
