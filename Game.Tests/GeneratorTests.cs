using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Game.Tests
{
    class GeneratorTests
    { 
        [Test]
        public void GenerateOneFilled()
        {
            var board = new Board(TestsHelpers.GetBoardContent("Boards\\BoardValid.txt"));
            board = board.Generate(1);
            Assert.IsTrue(board.IsValid());
        }
    }
}
