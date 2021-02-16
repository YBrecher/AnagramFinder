using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AnagramFinderTest
{
    [TestClass]
    public class AnagramFinderTest
    {
        [TestMethod]
        public void TestGetUniqueCharacters()
        {
            AnagramFinder.AnagramFinder af = new AnagramFinder.AnagramFinder();

            af.GetUniqueChars("Hello").Should().Be("ehlo");
            af.GetUniqueChars("aaaa").Should().Be("a");
            af.GetUniqueChars("aaabcc").Should().Be("abc");
            af.GetUniqueChars("bac").Should().Be("abc");
        }

        [TestMethod]
        public void TestFinder()
        {
            AnagramFinder.AnagramFinder af = new AnagramFinder.AnagramFinder();

            List<string> wordList = new List<string> { "cab", "aaa", "abc", "cbbbba", "a", "qwer" };

            List<List<string>> resultList = af.Finder(wordList);

            resultList[0].Should().BeEquivalentTo("a","aaa");
            resultList[1].Should().BeEquivalentTo("abc", "cab", "cbbbba");
        }
    }
}
