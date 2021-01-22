using System;
using System.Linq;
using System.IO;
using System.Reflection;

namespace Game.Tests
{
    public class TestsHelpers
    {
        public static string[] GetBoardContent(string boardName)
        {
            string[] str = File.ReadLines(boardName).ToArray();
            /*foreach (var value in str)
            {
                Console.WriteLine(value);
            }*/
            return str;
        }
    }
}