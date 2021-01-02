using System;
using System.Linq;
using System.IO;
using System.Reflection;
using NUnit.Framework;

namespace Game.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        static string[] GetBoardContent(string boardName)
        {
            string[] str = File.ReadLines(boardName).ToArray();
            /*foreach (var value in str)
            {
                Console.WriteLine(value);
            }*/
            return str;
        }

        [Test]
        public void Test1()
        {
            var validSudoku = GetBoardContent("Boards\\BoardValid.txt");
            Board board = new Board(validSudoku);
            foreach (var value in board.AsStrings())
            {
                Console.WriteLine(value);
            }
            Assert.AreEqual(validSudoku, board.AsStrings());
        }
        [Test]
        public void Test2()
        {
            var validSudoku = GetBoardContent("Boards\\BoardValid.txt");
            Board board = new Board(validSudoku);
            Assert.IsTrue(board.IsValid());
        }
        [Test]
        public void Test3()
        {
            var validSudoku = GetBoardContent("Boards\\BoardVerticalError.txt");
            Board board = new Board(validSudoku);
            Assert.IsFalse(board.IsValid());
        }
        [Test]
        public void Test4()
        {
            var validSudoku = GetBoardContent("Boards\\BoardHorizontalError.txt");
            Board board = new Board(validSudoku);
            Assert.IsFalse(board.IsValid());
        }
        [Test]
        public void Test5()
        {
            var validSudoku = GetBoardContent("Boards\\BoardTileError.txt");
            Board board = new Board(validSudoku);
            Assert.IsFalse(board.IsValid());
        }
    }
}