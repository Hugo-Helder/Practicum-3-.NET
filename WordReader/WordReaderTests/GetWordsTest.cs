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

        [TestCase('a', 62)]
        [TestCase('b', 25)]
        [TestCase('c', 20)]
        [TestCase('d', 16)]
        [TestCase('e', 4)]
        [TestCase('f', 23)]
        [TestCase('g', 16)]
        [TestCase('h', 18)]
        [TestCase('i', 37)]
        [TestCase('j', 1)]
        [TestCase('k', 2)]
        [TestCase('l', 15)]
        [TestCase('m', 15)]
        [TestCase('n', 7)]
        [TestCase('o', 37)]
        [TestCase('p', 30)]
        [TestCase('q', 4)]
        [TestCase('r', 8)]
        [TestCase('s', 29)]
        [TestCase('t', 79)]
        [TestCase('u', 3)]
        [TestCase('v', 4)]
        [TestCase('w', 23)]
        [TestCase('x', 0)]
        [TestCase('y', 16)]
        [TestCase('z', 0)]
        public void ShouldReturnArrayWithWordsThatOnlyThatStartsWithACertainLetter(char letter, int expectedAmount)
        {
            Assert.AreEqual(expectedAmount, Program.GetWords(_path, s => s.StartsWith(letter)).Count());
        }
    }
}
