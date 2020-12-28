using System;
using NUnit.Framework;

namespace Game.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        public string[] validSudoku = new string[] {"53..7....",
                                                    "6..195...",
                                                    ".98....6.",
                                                    "8...6...3",
                                                    "4..8.3..1",
                                                    "7...2...6",
                                                    ".6....28.",
                                                    "...419..5",
                                                    "....8..79" };

        [Test]
        public void Test1()
        {
            Board board = new Board(validSudoku);
            foreach(var value in board.AsStrings())
            {
                Console.WriteLine(value);
            }
            Assert.AreEqual(validSudoku, board.AsStrings());
        }
    }
}