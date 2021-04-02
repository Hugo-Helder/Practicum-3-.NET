using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using WordReader;

namespace WordReaderTests
{
    public class GetWordsTest
    {
        private readonly string _path =
            Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty,
                @"Resources\randomtext.txt");

        [TestCase('a', 59)]
        [TestCase('b', 24)]
        [TestCase('c', 17)]
        [TestCase('d', 15)]
        [TestCase('e', 4)]
        [TestCase('f', 22)]
        [TestCase('g', 12)]
        [TestCase('h', 18)]
        [TestCase('i', 34)]
        [TestCase('j', 1)]
        [TestCase('k', 1)]
        [TestCase('l', 13)]
        [TestCase('m', 13)]
        [TestCase('n', 7)]
        [TestCase('o', 36)]
        [TestCase('p', 24)]
        [TestCase('q', 3)]
        [TestCase('r', 5)]
        [TestCase('s', 26)]
        [TestCase('t', 75)]
        [TestCase('u', 2)]
        [TestCase('v', 4)]
        [TestCase('w', 20)]
        [TestCase('x', 0)]
        [TestCase('y', 15)]
        [TestCase('z', 0)]
        public void ShouldReturnArrayWithWordsThatOnlyThatStartsWithACertainLetter(char letter, int expectedAmount)
        {
            Assert.AreEqual(expectedAmount, Program.GetWords(_path, s => s.StartsWith(letter)).Count());
        }
    }
}
