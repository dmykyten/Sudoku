using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Game.Tests
{
    class ValidatorTests
    {
        [Test]
        public void ValidBoard()
        {
            var validSudoku = TestsHelpers.GetBoardContent("Boards\\BoardValid.txt");
            Board board = new Board(validSudoku);
            Assert.IsTrue(board.IsValid());
        }
        [Test]
        public void VerticalError()
        {
            var validSudoku = TestsHelpers.GetBoardContent("Boards\\BoardVerticalError.txt");
            Board board = new Board(validSudoku);
            Assert.IsFalse(board.IsValid());
        }
        [Test]
        public void HorizontalError()
        {
            var validSudoku = TestsHelpers.GetBoardContent("Boards\\BoardHorizontalError.txt");
            Board board = new Board(validSudoku);
            Assert.IsFalse(board.IsValid());
        }
        [Test]
        public void TileError()
        {
            var validSudoku = TestsHelpers.GetBoardContent("Boards\\BoardTileError.txt");
            Board board = new Board(validSudoku);
            Assert.IsFalse(board.IsValid());
        }

    }
}
