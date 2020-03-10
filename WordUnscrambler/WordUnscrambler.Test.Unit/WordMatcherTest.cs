using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordUnscrambler.cs.Workers;

namespace WordUnscrambler.Test.Unit
{
    [TestClass]
    public class WordMatcherTest
    {
        private readonly WordMatcher wordmatcher = new WordMatcher();

        [TestMethod]
        public void scrambledWordMatchesGivenWordInTheList()
        {
            string[] words = { "cat", "chair", "more" };
            string[] scrambledwords = { "omre" };

            var matchedWords = wordmatcher.Match(scrambledwords, words);
            Assert.IsTrue(matchedWords.Count.Equals(1));
            Assert.IsTrue(matchedWords[0].Scrambledwords.Equals("omre"));
            Assert.IsTrue(matchedWords[0].Word.Equals("more"));
        }


        [TestMethod]
        public void scrambledWordMatchesGivenWordsInTheList()
        {
            string[] words = { "cat", "chair", "more" };
            string[] scrambledwords = { "omre","hcair" };

            var matchedWords = wordmatcher.Match(scrambledwords, words);
            Assert.IsTrue(matchedWords.Count.Equals(2));
            Assert.IsTrue(matchedWords[0].Scrambledwords.Equals("omre"));
            Assert.IsTrue(matchedWords[0].Word.Equals("more"));
            Assert.IsTrue(matchedWords[1].Scrambledwords.Equals("hcair"));
            Assert.IsTrue(matchedWords[1].Word.Equals("chair"));
        }
    }
}
